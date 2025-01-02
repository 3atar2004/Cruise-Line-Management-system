using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using Cruise_Line;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using System.Security.Permissions;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //=====================================HASH FUNC======================================
        public string HashPassword(string password)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);


                byte[] hashBytes = sha256.ComputeHash(passwordBytes);


                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }
                return hashString.ToString();
            }
        }
        //====================================================================================
        public int AddPerson(string username, string email, string address, string phone, string password,
              string fname, string lname, string role, string city, string country,
              int ssn, string gender)
        {
            string HashedPassword = HashPassword(password);


            string query = @"INSERT INTO person (Username, Email, Address, Phone, Password, FName, LName, Role, City, Country, Ssn, Gender) " +
                           "VALUES ('" + username + "', '" + email + "', '" + address + "', '" + phone + "', '" + HashedPassword + "', '" + fname + "', '" + lname + "', '" + role + "', '" + city + "', '" + country + "', " + ssn + ", '" + gender + "')";
            int result = dbMan.ExecuteNonQuery(query);


            if (result > 0)
            {
                int personId = (int)dbMan.ExecuteScalar(@"SELECT personID FROM person WHERE Username = '" + username + "'");

                if (role == "C")
                {

                    string queryCustomer = @"INSERT INTO Costumer (personID) VALUES (" + personId + ")";
                    dbMan.ExecuteNonQuery(queryCustomer);
                }
                /*else if (role == "S")
                {

                    string queryStaff = @"INSERT INTO Staff (personID) VALUES (" + personId + ")";
                    dbMan.ExecuteNonQuery(queryStaff);
                }*/
            }

            return result;
        }

        public int CountUsername(string username) /// To check if the username exists in the database
        {
            string query = "SELECT COUNT(*) FROM person WHERE Username = '" + username + "'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CountEmail(string email) /// check if email already exits in the database
        {
            string query = "SELECT COUNT(*) FROM person WHERE Email = '" + email + "'";
            return (int)dbMan.ExecuteScalar(query);
        }


        public DataTable Selectpassword(string username)
        {
            string query = "SELECT Password FROM Person WHERE Username='" + username + "';";
            return dbMan.ExecuteReader(query);
        }


        public char getRole(string username)
        {
            string query = "SELECT Role FROM person WHERE Username = '" + username + "';";

            object result = dbMan.ExecuteScalar(query);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToChar(result);
            }
            else
            {
                return '\0';
            }
        }

        public int changeEmail(string username, string newEmail)
        {
            //regex men 3al net
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(newEmail, emailPattern))
            {
                return 0;
            }


            string query = $"UPDATE person SET Email = '" + newEmail + "' WHERE Username = '" + username + "';";


            return dbMan.ExecuteNonQuery(query);
        }


        public int changePhone(string username, string phone)
        {
            string query = @"UPDATE person SET Phone = '" + phone + "' WHERE Username = '" + username + "'";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getPerson(string username)
        {
            string query = @"SELECT * FROM person WHERE Username = '" + username + "';";
            return dbMan.ExecuteReader(query);
        }

        public string getLoyalty(string username)
        {
            string query = @"
SELECT c.Loyalty_Points
FROM Costumer c
JOIN person p ON c.personID =p.personID
WHERE p.Username = '" + username + "'";


            object result = dbMan.ExecuteScalar(query);

            return result != null ? result.ToString() : null;
        }

        public int ChangePassword(string username, string password)
        {
            string HashedPassword = HashPassword(password);
            string query = $"UPDATE person SET Password = '" + HashedPassword + "' WHERE Username = '" + username + "';";


            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable searchCruises(DateTime Arrival, DateTime Start, string departure, string destination) ////// EndDate='"+Arrival+"' AND StartDate='"+Start+"' AND
        {
            string query = @"SElECT * FROM Cruise WHERE  Departure='" + departure + "' AND Destination='" + destination + "'";
            return dbMan.ExecuteReader(query);
        }

//================================================================VIEW BOOKED CRUISES=======================================================================
        public DataTable getBookedCruise(int userID,int CruiseID)
        {
            string query = @"
SELECT B.BookingID AS 'Booking Number',CONCAT(P.FName,' ',P.LName) AS 'Full Name',C.Name,B.BookingDate AS 'Booking Date',B.PaymentID
FROM person P
JOIN Booking B ON B.personID = P.personID
JOIN Cruise C ON C.CruiseID = B.CruiseID
WHERE P.personID=" + userID + " AND c.CruiseID = "+CruiseID+"";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getCruise(string username)
        {
            string query = @"
SELECT DISTINCT C.Name, C.CruiseID
FROM person P
JOIN Booking B ON B.personID = P.personID
JOIN Cruise C ON C.CruiseID = B.CruiseID
WHERE Username='" + username + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable searchActivities()
        {
            string query = "SELECT * FROM Activity;";
            return dbMan.ExecuteReader(query);
        }
        public int BookActivity(int count, int personId, int activityId,int paymentid)
        {
            string query = "INSERT INTO Activity_Reservation VALUES(" + count + "," + personId + "," + activityId + ","+paymentid+");";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable getpersonIdfromUsername(string username)
        {
            string query = "SELECT personID FROM person WHERE Username='" + username + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getActivityCapacity(int activityID)
        {
            string query = "SELECT Capacity FROM Activity WHERE ActivityID=" + activityID + ";";
            return dbMan.ExecuteReader(query);

        }
        public int UpdateActivityBooking(int count, int personId, int activityId,int paymentid)
        {
            string query = "UPDATE Activity_Reservation SET Count ="+count+ " WHERE personID =" + personId+ " AND ActivityID ="+activityId+" ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetpaymentId(int personid)
        {
            string query = "SELECT PaymentID FROM Booking WHERE personID="+personid+";";
            return dbMan.ExecuteReader(query);
        }
        ///############Manager Interface Functions#################################
        public DataTable getAvailableships(DateTime start, DateTime end)
        {
            string query = $"SELECT S.ShipID, S.Name\r\nFROM Ship S\r\nWHERE ShipID NOT IN (SELECT DISTINCT C.ShipID\r\nFROM Cruise C\r\nWHERE C.StartDate <= '{end}' AND C.EndDate >= '{start}');";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getcruises()
        {
            string query = "SELECT Name,CruiseID FROM Cruise";
            return dbMan.ExecuteReader(query);
        }
        public int InsertCruise(string desc, DateTime start, DateTime end, string dept, string dest, int shipid, string Name)
        {
            string query = $"INSERT INTO Cruise (Name,Description,EndDate,StartDate,Departure,Destination,ShipID) VALUES('{Name}','{desc}','{end}','{start}','{dept}','{dest}',{shipid})";
            return dbMan.ExecuteNonQuery(query);
        }

        public DateTime getStartDate(int id)
        {
            string query = $"SELECT StartDate FROM Cruise Where CruiseID={id}";
            return (DateTime)dbMan.ExecuteScalar(query);
        }
        public DateTime getendDate(int id)
        {
            string query = $"SELECT EndDate FROM Cruise Where CruiseID={id}";
            return (DateTime)dbMan.ExecuteScalar(query);
        }
        public int insertactivity(int crid,int cap,string name,decimal cost, DateTime date, string description,TimeSpan time)
        {
            string formattedDate = date.ToString("yyyy-MM-dd"); 
            string formattedTime = time.ToString(@"hh\:mm\:ss"); 
            string query = $"INSERT INTO Activity(Capacity, Name, Cost, Date, Description, Time, CruiseID) " +
                           $"VALUES({cap}, '{name}', {cost}, '{formattedDate}', '{description}', '{formattedTime}', {crid})";

            return dbMan.ExecuteNonQuery(query);

        }
        public int AddStaff(string job, int id)
        {
            string query = $"INSERT INTO STAFF(Job,personID) VALUES('{job}',{id})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getstaffid(string username)
        {
            string query = $"SELECT PersonID FROM Person WHERE Username='{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable getAllRoles()
        {
            string query = "SELECT DISTINCT Job FROM Staff;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAvailableStaff(DateTime start,DateTime end, string role)
        {
            string query;
            if (role == "All")
            {
                query = $"SELECT person.personID, CONCAT(person.FName, ' ', person.LName) AS FullName, Staff.Job, person.Gender, person.Phone, person.Address FROM Staff INNER JOIN person ON Staff.personID = person.personID WHERE NOT EXISTS ( SELECT * FROM Works_On INNER JOIN Cruise ON Works_On.CruiseID = Cruise.CruiseID WHERE Works_On.personID = Staff.personID AND Cruise.StartDate <= '{end}' AND Cruise.EndDate >= '{start}');";
            }
            else
            {
                query = $"SELECT person.personID, CONCAT(person.FName, ' ', person.LName) AS FullName, Staff.Job, person.Gender, person.Phone, person.Address FROM Staff INNER JOIN person ON Staff.personID = person.personID WHERE Staff.Job = '{role}' AND NOT EXISTS ( SELECT * FROM Works_On INNER JOIN Cruise ON Works_On.CruiseID = Cruise.CruiseID WHERE Works_On.personID = Staff.personID AND Cruise.StartDate <= '{end}' AND Cruise.EndDate >= '{start}') ;";
            }
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable getAssignedStaff(int CruiseID)
        {
            string query = $"SELECT person.personID, CONCAT(person.FName, ' ', person.LName) AS FullName, Staff.Job, person.Gender, person.Phone, person.Address FROM Staff,Works_On,Cruise,person WHERE Cruise.CruiseID = Works_On.CruiseID AND Staff.personID = Works_On.personID AND person.personID = Staff.personID AND Cruise.CruiseID = {CruiseID};";
            return dbMan.ExecuteReader(query);
        }

        public int addWorks_On(int cruiseID, int staffID)
        {
            string query = $"INSERT INTO Works_On(personID,CruiseID) VALUES({staffID},{cruiseID});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int removeWorks_On(int CruiseID, int staffID)
        {
            string query = $"DELETE FROM Works_On WHERE personID = {staffID} AND CruiseID = {CruiseID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updateperson(string username,string fname,string lname,int ssn,string address,string city,string country,string phone)
        {
            string query = $"UPDATE person SET Fname='{fname}',Lname='{lname}',Ssn={ssn},Address='{address}',City='{city}',Country='{country}',Phone='{phone}' WHERE Username='{username}'";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable SearchCruises(string departure, string destination, string minprice)
        {
            string dateFormatted = DateTime.Today.ToString("yyyy-MM-dd");
            string baseQuery = @"
SELECT 
    c.CruiseID AS 'Cruise Number',
    c.Name AS 'Cruise Name', 
    sh.ShipID AS 'Ship ID', 
    sh.Name AS 'Ship Name', 
    c.Description, 
    c.EndDate AS 'From', 
    c.StartDate AS 'Till', 
    c.Destination, 
    c.Departure, 
    MIN(CS.Price_Per_Night) AS 'Starting Price Per Night/$', 
    MAX(CS.Price_Per_Night) AS 'Luxury Price Up To/$'
FROM Cruise c
JOIN Ship sh ON sh.ShipID = c.ShipID
LEFT JOIN CabinsOnShip CS ON sh.ShipID = CS.ShipID
WHERE 1=1
AND c.StartDate >= '"+dateFormatted+"'";

            if (!string.IsNullOrEmpty(departure) && departure != "None")
            {
                baseQuery += " AND c.Departure = '" + departure + "'";
            }
            if (!string.IsNullOrEmpty(destination) && destination != "None")
            {
                baseQuery += " AND c.Destination = '" + destination + "'\n";
            }

            baseQuery += @"
GROUP BY
    c.CruiseID,
    c.Name,
    sh.ShipID,
    sh.Name, 
    c.Description, 
    c.EndDate, 
    c.StartDate, 
    c.Destination, 
    c.Departure";

            if (!string.IsNullOrEmpty(minprice) && Convert.ToInt32(minprice) > 0)
            {
                baseQuery += @" HAVING MIN(CS.Price_Per_Night) <= " + minprice + " ";
            }

            baseQuery += " ORDER BY c.StartDate;";

            return dbMan.ExecuteReader(baseQuery);
        }

        public DataTable getDeparture()
        {
            string query = $"SELECT DISTINCT Departure FROM Cruise ORDER BY Departure;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getDestination()
        {
            string query = $"SELECT DISTINCT Destination FROM Cruise ORDER BY Destination;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getCruises()
        {
            string query = $"SELECT c.CruiseID AS 'Cruise Number',c.Name AS 'Cruise Name', c.ShipID AS 'Ship ID',c.Description, c.EndDate AS 'From', c.StartDate AS 'Till', c.Destination, c.Departure FROM Cruise c";
            return dbMan.ExecuteReader(query);
        }

        public int deleteCruise(int cruiseID)
        {
            string query = $"DELETE FROM Cruise WHERE CruiseID = {cruiseID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getcruisebyid(int id)
        {
            string query = $"SELECT * FROM Cruise WHERE CruiseID={id}";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateCruise(int cruisenumber,string desc, DateTime start, DateTime end, string dept, string dest, string Name)
        {
            string query = $"UPDATE Cruise SET Name='{Name}',Description='{desc}',EndDate='{end}',StartDate='{start}',Departure='{dept}',Destination='{dest}' WHERE CruiseID ={cruisenumber}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addShip(string Name)
        {
            string query = $"INSERT INTO Ship (Name) VALUES('{Name}'); SELECT SCOPE_IDENTITY();";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public int addCabins(int shipID, int singleAmount, int singlePrice, int doubleAmount, int doublePrice, int tripleAmount, int triplePrice)
        {
        
            for (int i = 0; i<singleAmount; i++)
            {
                string query = $"INSERT INTO CabinsOnShip (Type, Price_Per_Night, ShipID) VALUES(1,{singlePrice},{shipID});";
                int result = (int)dbMan.ExecuteNonQuery(query);
                if (result == 0)
                {
                    return 0;
                }
            }

            for (int i = 0; i < doubleAmount; i++)
            {
                string query = $"INSERT INTO CabinsOnShip (Type, Price_Per_Night, ShipID) VALUES(2,{doublePrice},{shipID});";
                int result = (int)dbMan.ExecuteNonQuery(query);
                if (result == 0)
                {
                    return 0;
                }
            }

            for (int i = 0; i < tripleAmount; i++)
            {
                string query = $"INSERT INTO CabinsOnShip (Type, Price_Per_Night, ShipID) VALUES(3,{triplePrice},{shipID});";
                int result = (int)dbMan.ExecuteNonQuery(query);
                if (result == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        public int CountShipName(string shipName)
        {
            string query = $"SELECT COUNT(Name) FROM Ship WHERE Name = '{shipName}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public DataTable getassigned(string username)
        {
            string query = $"SELECT Name,Departure,Destination,StartDate,EndDate FROM Cruise C ,Works_on W, Person P WHERE C.CruiseID = W.CruiseID AND P.personID=w.personID AND Username='{username}'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getworkingcruise(string username)
        {
            string query = $"SELECT C.CruiseID,C.Name FROM Cruise C,Person P, Works_on W WHERE C.CruiseID= W.CruiseID AND P.personID=W.personID AND P.Username='{username}'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getOccupied(int cruiseId, string firstname, string lastname)
        {

            string query = $"SELECT DISTINCT CONCAT(P.FName,' ',P.LName) AS 'Full Name', cs.CabinID AS 'Cabin Number', cs.Type AS 'Cabin Type', cs.Price_Per_Night AS 'Price per night', cs.ShipID AS 'Ship ID', B.BookingID AS 'Booking ID'\r\nFROM person P\r\nJOIN Booking B ON P.personID = B.personID\r\nJOIN Assigned_Cabins C ON C.BookingID = B.BookingID\r\nJOIN CabinsOnShip cs ON cs.ShipID = C.ShipID\r\nWHERE B.CruiseID = {cruiseId} AND C.CabinID = cs.CabinID";
            if (!string.IsNullOrEmpty(firstname))
            {
                query += $" AND P.FName = '{firstname}'";
            }
            if (!string.IsNullOrEmpty(lastname))
            {
                query += $" AND P.LName = '{lastname}'";
            }
            return dbMan.ExecuteReader(query);
        }

        public DataTable getavailablecabins(int cruiseId,int type)
        {
            string query = $"SELECT c.CabinID, c.Type, c.Price_Per_Night, c.ShipID\r\nFROM CabinsOnShip c\r\nJOIN Cruise cr\r\nON c.ShipID = cr.ShipID\r\nWHERE cr.CruiseID = {cruiseId} AND c.Type = {type} AND NOT EXISTS (   SELECT *     FROM Assigned_Cabins ac     WHERE ac.CabinID = c.CabinID AND ac.ShipID = c.ShipID);";
            return dbMan.ExecuteReader(query);
        }

        public int updateAssignedCabin (int newCabin, int oldCabin, int shipID, int BookingID)
        {
            string query = $"UPDATE Assigned_Cabins SET CabinID = {newCabin} WHERE CabinID = {oldCabin} AND ShipID = {shipID} AND BookingID = {BookingID};";
            return dbMan.ExecuteNonQuery(query);
        }

        public int getNumberAvailableCabins(int cruiseID,int CabinType)
        {
            string query = @"SELECT 
    (COUNT(cs.CabinID) - COUNT(ac.CabinID)) AS UnbookedCabins
FROM 
    Cruise c
JOIN CabinsOnShip cs 
    ON c.ShipID = cs.ShipID
LEFT JOIN Assigned_Cabins ac 
    ON cs.CabinID = ac.CabinID AND c.ShipID = ac.ShipID
WHERE 
    c.CruiseID = "+cruiseID+" AND cs.Type = "+CabinType+";";



            object result = dbMan.ExecuteScalar(query);
            return Convert.ToInt32(result);
            
        }

        public int getPricePerNight(int shipID, int identifier)
        {
            string query = @"SELECT c.Price_Per_Night
FROM CabinsOnShip c
WHERE c.Type= "+identifier+" AND c.ShipID = "+shipID+" ";

            object result = dbMan.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
        public int makePayment(int PayAmount)
        {
            // Sanitize PayAmount input to ensure it's a valid number
            if (PayAmount <= 0)
            {
                throw new ArgumentException("PayAmount must be a positive value.");
            }

            // Format the date as 'yyyy-MM-dd' to prevent issues with date formats
            string dateFormatted = DateTime.Today.ToString("yyyy-MM-dd");

            
            string query = @"
INSERT INTO Payment (PayDate, PayAmount)
VALUES ('" + dateFormatted + "', " + PayAmount + ");" +
"SELECT SCOPE_IDENTITY(); "; 

    
    return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int GetUserIdByUsername(string username)
        {
            string query = @"
SELECT personID
FROM person
WHERE Username = '"+username+"'";

                return Convert.ToInt32(dbMan.ExecuteScalar(query));
            
        }

public int makeBooking(int user_id, int? payment_id, int cruiseID)
{
    
    string dateFormatted = DateTime.Today.ToString("yyyy-MM-dd");

    // Handle null for PaymentID in the query
    string paymentValue = payment_id.HasValue ? payment_id.ToString() : "NULL";

    
    string query = @"
INSERT INTO Booking (personID, PaymentID, CruiseID, BookingDate)
VALUES
('" + user_id + "', " + paymentValue + ", '" + cruiseID + "', '" + dateFormatted + "');" +
"SELECT SCOPE_IDENTITY();";

        return Convert.ToInt32(dbMan.ExecuteScalar(query));
    
}


        public int AssignCabin(int CabinID,int ShipID,int BookingID)
        {
            string query = @"INSERT INTO Assigned_Cabins(CabinID,ShipID,BookingID)
VALUES("+CabinID+","+ShipID+","+BookingID+")";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int getCabinID(int cruiseID, int cabinTypeint)
        {
            string query = @"SELECT TOP 1
    cs.CabinID
FROM 
    Cruise c
JOIN CabinsOnShip cs 
    ON c.ShipID = cs.ShipID
LEFT JOIN Assigned_Cabins ac 
    ON cs.CabinID = ac.CabinID AND c.ShipID = ac.ShipID
WHERE 
    c.CruiseID = "+cruiseID+" " +
    "AND cs.Type = "+cabinTypeint+"" +
    "AND ac.CabinID IS NULL" +
    "  ORDER BY " +
    "cs.CabinID ASC;";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }


        //=========================================================================================================================================================
       public DataTable getactivitiesoncruise(int cruiseid)
        {
            string query = $"SELECT ActivityID AS 'Activity ID',Name AS 'Name' FROM Activity WHERE CruiseID={cruiseid}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getactivityreservations(int activityid)
        {
            string query = $"SELECT P.Fname AS Name, Ac.Count As Count FROM person P,Activity_Reservation Ac,Activity A WHERE P.personID= Ac.personID AND A.ActivityID=Ac.ActivityID AND A.ActivityID={activityid}";
            return dbMan.ExecuteReader(query);
        }

        public int getCost(int activityID)
        {
            string query = @"
	SELECT Cost
	FROM Activity
	WHERE Activity.ActivityID = " + activityID + "";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpdateLoyaltyPoints(int user_id, int pointsToAdd)
        {
            
            string query = @"
UPDATE Costumer
SET Loyalty_Points = ISNULL(Loyalty_Points, 0) + " + pointsToAdd + @"
WHERE personID = " + user_id + ";";

            
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getBookedCabins(string username,int cruiseID)
        {
            string query = @"SELECT CONCAT(p.FName, ' ', p.LName) AS 'Full Name',
ac.CabinID,
c.Name,
b.BookingDate,
co.Type,
b.PaymentID
FROM person p
JOIN Booking b ON b.personID = p.personID
JOIN Assigned_Cabins ac ON b.BookingID = ac.BookingID
JOIN Cruise c ON c.CruiseID = B.CruiseID
JOIN CabinsOnShip co ON co.CabinID = ac.CabinID
WHERE c.CruiseID = " + cruiseID + " AND p.Username = '" + username + "';";

            return dbMan.ExecuteReader(query);
        }

        public int GetActivityCount(int activityid)
        {
            string query = "SELECT SUM(Count) FROM Activity_Reservation WHERE ActivityID=" + activityid + ";";
            return (int)dbMan.ExecuteScalar(query);

        }
        public DataTable GetReservedActivityinfo(int activityid, int personid)
        {
            string query = "SELECT DISTINCT p.personID,FName,Name,Cost,Date,Description,Time,a.ActivityID FROM person p,Activity a,Activity_Reservation r WHERE a.ActivityID=r.ActivityID AND a.ActivityID =" + activityid + " AND p.personID=" + personid + ";";
            return dbMan.ExecuteReader(query);
        }
        public string getfirstname(string username)
        {
            string query = $"SELECT Fname FROM person WHERE Username='{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }
        public decimal gettotalrecieved()
        {
            string query = "SELECT SUM(PayAmount) FROM Payment";
            return (decimal)dbMan.ExecuteScalar(query);
        }
        public decimal gettotalbooking()
        {
            string query = "select sum(Cs.price_per_night*DATEDIFF(DAY, C.StartDate, C.EndDate)) from Assigned_Cabins Ac join CabinsOnShip Cs on Ac.CabinID=Cs.CabinID join Booking B on B.BookingID =ac.BookingID join Cruise C on B.CruiseID = C.CruiseID";
            return Math.Round((decimal)dbMan.ExecuteScalar(query),2);
        }
        public decimal gettotalactivity()
        {
            string query = "select sum(AR.Count*A.Cost)\r\nfrom Activity A ,Activity_Reservation AR\r\nwhere  A.ActivityID=AR.ActivityID";
            return Math.Round((decimal)dbMan.ExecuteScalar(query),2);
        }
        public int getbookingcount()
        {
            string query = "SELECT COUNT(*) FROM Booking";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getongoingcruisecount(string todaysdate)
        {
            string query = $"select count(*)\r\nfrom Cruise\r\nwhere StartDate<'{todaysdate}' AND EndDate>'{todaysdate}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getstaffcount()
        {
            string query = "SELECT COUNT(*) FROM STAFF";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int getcustomercount()
        {
            string query = "SELECT COUNT(DISTINCT personID) from Booking";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable showcruisereport()
        {
            string query = "SELECT C.Name,Count(B.BookingID) as'Number of Booking',C.Departure,C.Destination,C.StartDate as 'Start Date',C.EndDate as 'End Date' from Booking B,Cruise C where B.CruiseID=C.CruiseID group by C.Name,C.Departure,C.Destination,C.StartDate,C.EndDate order by 'Number of Booking' desc";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getnumberofbooked()
        {
            string query = "SELECT COUNT(Ac.CabinID) AS 'Number of Booked Cabins'\r\nfrom Assigned_Cabins Ac\r\njoin Booking B on B.BookingID=Ac.BookingID\r\njoin Cruise C on C.CruiseID=B.CruiseID\r\nGROUP BY C.Name ";
            return dbMan.ExecuteReader(query);

        }
        public DataTable getallcabins()
        {
            string query = "SELECT C.Name,COUNT(Cs.CabinID) AS 'Total Number of Cabins'\r\nfrom CabinsOnShip Cs\r\njoin Ship S on cs.ShipID=S.ShipID\r\njoin Cruise C on C.ShipID= S.ShipID\r\ngroup by C.Name";
            return dbMan.ExecuteReader(query);
        }
        public DataTable rankcustomers()
        {
            string query = "Select P.Username,CONCAT(P.FName,' ',P.LName) AS 'Full Name',Loyalty_Points as 'Loyalty Points',COUNT(B.BookingID) as 'Number of Bookings'\r\nfrom person P,Costumer C,Booking B\r\nwhere B.personID=P.personID and C.personID=P.personID \r\nGROUP BY P.Username,P.FName,P.LName,Loyalty_Points\r\norder by C.Loyalty_Points desc";
            return dbMan.ExecuteReader(query);
        }

        public string getMaxCruise()
        {
            string query = "SELECT TOP 1 C.Name\r\nFROM Cruise C, Booking B\r\nWHERE C.CruiseID = B.CruiseID \r\nGROUP BY C.Name\r\nORDER BY Count(B.BookingID) DESC";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string getMinCruise()
        {
            string query = "SELECT TOP 1 C.Name\r\nFROM Cruise C, Booking B\r\nWHERE C.CruiseID = B.CruiseID \r\nGROUP BY C.Name\r\nORDER BY Count(B.BookingID)";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public DataTable getPaidActivities(string username)
        {
            string query = @"	SELECT 
    p.Ssn,
    CONCAT(p.FName, ' ', p.LName) AS 'Full Name',
    p.Phone,
    a.Name,
    a.CruiseID,
    ar.Count,
    a.Cost AS 'Cost',
    a.Cost * ar.Count AS 'Total Cost',
    a.Date,
    a.Time,
    ar.PaymentID,
    pay.PayAmount,
    pay.PayDate
FROM 
    person p
JOIN 
    Activity_Reservation ar ON ar.personID = p.personID
JOIN 
    Activity a ON a.ActivityID = ar.ActivityID
JOIN 
    Payment pay ON pay.PaymentID = ar.PaymentID
WHERE 
    p.Username = '" + username + "' AND ar.PaymentID IS NOT NULL;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getPaidCruise(string username)
        {
            string query = @"SELECT p.Ssn,CONCAT(p.FName,' ',p.LName)AS 'Full Name',p.Phone,c.Name,c.Departure,c.Destination,c.StartDate,c.EndDate,pay.PaymentID, pay.PayAmount,PayDate
FROM person p
JOIN Booking b ON b.personID = p.personID
JOIN Payment pay ON pay.PaymentID = b.PaymentID
JOIN Cruise c ON c.CruiseID = b.CruiseID
WHERE p.Username = '" + username + "'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getUnpaidCruise(string username)
        {
            string query = @"SELECT 
    p.Ssn,
    CONCAT(p.FName, ' ', p.LName) AS 'Full Name',
    p.Phone,
    c.Name,
    c.Departure,
    c.Destination,
    c.StartDate,
    c.EndDate,
    b.BookingID
FROM 
    person p
JOIN 
    Booking b ON b.personID = p.personID
LEFT JOIN 
    Payment pay ON pay.PaymentID = b.PaymentID
JOIN 
    Cruise c ON c.CruiseID = b.CruiseID
WHERE 
    pay.PaymentID IS NULL
	AND p.Username= '" + username + "'";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getUnpaidActivites(string username)
        {
            string query = @"SELECT    
	p.Ssn,
    CONCAT(p.FName, ' ', p.LName) AS 'Full Name',
    a.ActivityID,
    p.Phone,
    a.Name,
    a.CruiseID,
    ar.Count,
    a.Cost AS 'Cost',
    a.Cost * ar.Count AS 'Total Cost',
    a.Date,
    a.Time,
	ar.PaymentID
FROM person p
LEFT JOIN Activity_Reservation ar ON ar.personID=p.personID
JOIN Activity a ON ar.ActivityID = a.ActivityID
WHERE ar.PaymentID IS NULL AND p.Username = '" + username + "'";

            return dbMan.ExecuteReader(query);
        }

        public int getBookingTotal(int BookingID)
        {
            string query = @"	SELECT SUM(c.Price_Per_Night)
	FROM Assigned_Cabins a
	JOIN Booking b ON b.BookingID = a.BookingID
	JOIN CabinsOnShip c ON c.CabinID = a.CabinID
	WHERE b.BookingID = " + BookingID + "";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpdateCruiseBooking(int bookingID, int payment_id)
        {
            string query = @"	UPDATE Booking SET PaymentID = " + payment_id + " WHERE BookingID = " + bookingID + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateActivityPayment(int PaymentID, int personID, int ActivityID)
        {
            string query = @"UPDATE Activity_Reservation SET PaymentID = " + PaymentID + " WHERE personID = " + personID + " AND ActivityID = " + ActivityID + ";";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetReservedActivityinfo(int personid)
        {
            string query = "SELECT p.personID, p.FName,a.Name, a.Cost, a.Date, a.Description, a.Time, a.ActivityID FROM person p JOIN Activity_Reservation r ON p.personID = r.personID JOIN Activity a ON a.ActivityID = r.ActivityID WHERE  p.personID = " + personid + " GROUP BY a.ActivityID,a.Name, p.personID, p.FName, a.Cost, a.Date, a.Description, a.Time;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetCrusieidbyPersonid(int personid)
        {
            string query = "SELECT CruiseID FROM Booking WHERE personID=" + personid + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable searchActivities(int cruiseid)
        {
            string query = "SELECT * FROM Activity WHERE CruiseID=" + cruiseid + ";";
            //string query = "SELECT * FROM Activity";
            return dbMan.ExecuteReader(query);
        }
    }

}
