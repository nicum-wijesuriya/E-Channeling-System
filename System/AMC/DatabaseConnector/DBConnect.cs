using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DatabaseConnector
{
    public class DBConnect
    {
		private String DbName;
		private String Username;
		private String Password;	
		private MySqlConnectionStringBuilder ConnectionString;
		private MySqlConnection connection;

		public  const int DOES_NOT_EXPECT_RESULT_SET = 1;
		public  const int EXPECT_RESULT_SET = 2;

		public MySqlConnection Connection
		{
			get
			{
				return connection;
			}			
		}
		private String Server;
		private static DBConnect myConnection;


		private DBConnect(String Server, String DbName, String Username, String Password)
		{
			this.DbName = DbName;
			this.Username = Username;
			this.Password = Password;
			this.Server = Server;

			this.ConnectionString = new MySqlConnectionStringBuilder();
			this.ConnectionString.Server = this.Server;
			this.ConnectionString.UserID = this.Username;
			this.ConnectionString.Password = this.Password;
			this.ConnectionString.Database = this.DbName;

			this.connection = new MySqlConnection(this.ConnectionString.ToString());
		}

		public static DBConnect Connect()
		{
			if(DBConnect.myConnection == null)
			{
				return new DBConnect("localhost", "amc", "root", "root");
			}
			else
			{
				return DBConnect.myConnection;
			}
		}
			

		public MySqlDataReader ExecuteProcedure(MySqlCommand command,int type)
		{
			try
			{

				this.Connection.Open();
				switch (type)
				{
					case 1:
						command.ExecuteNonQuery();
						return null;

					default:
						return command.ExecuteReader();
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("SQL Exception : ");
				Console.WriteLine("");
				
				Console.WriteLine(ex);

				return null;
			}
		}
    }
}
