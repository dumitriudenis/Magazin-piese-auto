using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Clase;

namespace WindowsFormsApp2
{
    class Comenzi_SQL
    {
        //#region connection

        #region CREATE TABLES

        public static string CreateCategorieTable()
        {
            string command =
            @" CREATE TABLE client(
                id           NUMBER NOT NULL PRIMARY KEY,
                category_name   VARCHAR(50) NOT NULL,
                )";
            return command;
        }

        public static string CreateClientTable()
        {
            string command =
            @" CREATE TABLE client(
                id           NUMBER NOT NULL PRIMARY KEY ,
                city         VARCHAR(50) NOT NULL,
                first_name   VARCHAR(50) NOT NULL,
                last_name    VARCHAR(50) NOT NULL,
                birthday     VARCHAR(20) NOT NULL,
                address      VARCHAR(100) NOT NULL,
                phone_number VARCHAR(15) NOT NULL,
                password     VARCHAR(50) NOT NULL,
                email        VARCHAR(50) NOT NULL
                )";
            return command;
        }

        public static string CreateClientiTable()
        {
            string command =
            @" CREATE TABLE clienti(
                client_id    NUMBER NOT NULL PRIMARY KEY ,
                password     VARCHAR(50) NOT NULL,
                email        VARCHAR(50) NOT NULL
                )";
            return command;
        }

        public static string CreateComenziTable()
        {
            string command =
            @" CREATE TABLE comenzi(
                id_order            NUMBER NOT NULL PRIMARY KEY,
                oder_date           VARCHAR(11) NOT NULL,
                produs_quantity     NUMBER NOT NULL ,
                id_client           NUMBER NOT NULL ,
                price               NUMBER NOT NULL
                )";
            return command;
        }

        public static string CreateDetalii_ComandaTable()
        {
            string command =
            @" CREATE TABLE detalii_comanda(
                order_id            NUMBER NOT NULL PRIMARY KEY,
                name                VARCHAR(50) NOT NULL,
                produs_quantity     NUMBER NOT NULL ,
                oder_date           VARCHAR(11) NOT NULL,
                product_id          NUMBER NOT NULL ,
                price               NUMBER NOT NULL
                )";
            return command;
        }

        public static string CreateLista_ProduseTable()
        {
            string command =
            @" CREATE TABLE lista_produse(
                id                  NUMBER NOT NULL PRIMARY KEY,
                product_name        VARCHAR(50) NOT NULL,
                price               NUMBER NOT NULL,
                category            VARCHAR(50) NOT NULL
                )";
            return command;
        }

        public static string CreateProdusTable()
        {
            string command =
                @" CREATE TABLE produs(
                id           NUMBER NOT NULL PRIMARY KEY,
                order_id     NUMBER NOT NULL ,
                product_name VARCHAR(50) NOT NULL,
                price        NUMBER NOT NULL,
                description  VARCHAR(100) NOT NULL,
                quality      VARCHAR(20) NOT NULL,
                category     VARCHAR(50) NOT NULL
                )";
            return command;
        }

        #endregion

        #region DROP TABLES

        public static string DropCategorieTable()
        {
            string command = "DROP TABLE categorie";
            return command;
        }

        public static string DropClientTable()
        {
            string command = "DROP TABLE client";
            return command;
        }

        public static string DropClientiTable()
        {
            string command = "DROP TABLE clienti";
            return command;
        }

        public static string DropComenziTable()
        {
            string command = "DROP TABLE comenzi";
            return command;
        }

        public static string DropDetalii_ComandaTable()
        {
            string command = "DROP TABLE detalii_comanda";
            return command;
        }

        public static string DropLista_ProduseTable()
        {
            string command = "DROP TABLE lista_produse";
            return command;
        }

        public static string DropProdusTable()
        {
            string command = "DROP TABLE produs";
            return command;
        }

        #endregion

        #region INSTANTIATE TABLES  
        public static bool ExecuteOracleCommand(string command, OracleConnection conn)
        {
                        
                       try
                       {
                            var sqlCommand = new OracleCommand
                           {
                               Connection = conn,
                               CommandText = command,
                               CommandType = CommandType.Text
                           };
                         sqlCommand.ExecuteReader();
                       }
                       catch (System.Exception de)
                       {
                           MessageBox.Show(de.Message, "Database Error", MessageBoxButtons.OKCancel);
                            return false;
                       }
            return true;
        }

        #endregion

        #region INSERT TABLES
         
        public static string  UpdateClient( int id,string city,string firstName,string lastName, string birthday,string address,string phoneNumber, string password,string email)
        {
            string command = " INSERT INTO client VALUES(" + id + ",'" + city + "','" + firstName + "','" + lastName +"','" +
                birthday + "','" + address + "','" + phoneNumber + "','" + password +"','" +email +"')";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);
        }

        public static string UpdateCategory(int id,string category_name)
        {
            string command = "INSERT INTO categorie VALUES(" + id + ",'" + category_name + "')";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);  
        }

        public static string UpdateProdus(int id, int order_id, string product_name, double price, string description, int quality, string category)
        {
            string command = " INSERT INTO produs VALUES(" + id + ",'" + order_id + "','" + product_name + "','" + price + "','" +
                description + "','" + quality + "','" + category + "')";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);
    }

        #endregion

        #region INTEROGATE_TABLES

        public static string Search_Databse_client(string email , string password)
        {
            string command = @"SELECT email, password 
                            FROM client
                            
                            WHERE email = '" + email + "'" + "and password = '" + password + "'";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);  
        }

        public static string Search_Database_client_name(string name)
        {
            string command = @"SELECT *               
                            FROM client               
                            WHERE first_name = '" + name + "' or last_name ='" + name +"'";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);  
        }

        public static string Search_Database_product_name(string name)
        {
            string command = @"SELECT *               
                            FROM produs               
                            WHERE product_name = '" + name + "' or description like '%" + name + "%'";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);  
        }

        public static string Search_Database_product_category(string name)
        {
            string command = @"SELECT *               
                            FROM produs               
                            WHERE category = '" + name + "'";
            return command;
            //Comenzi_SQL.ExecuteOracleCommand(command, conn);  
        }

        public static string Ascending_Order_product(string cond)
        {
            string command = @"SELECT *               
                            FROM produs               
                            order by " + cond + "";
            return command;
        }

        public static string Descending_Order_product(string cond)
        {
            string command = @"SELECT *               
                            FROM produs               
                            order by " + cond + " desc";
            return command;
        }

        #endregion
    }
}
