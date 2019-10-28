using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using TestRequest.db;
using TestRequest.Properties;

namespace TestGate
{
    public sealed class CDataBase
    {


        public void InitDB(string FileDB)
        {
            ActiveRecordStarter.ResetInitializationFlag();

            IDictionary<string, string> properties = new Dictionary<string, string>
            {
                {"connection.driver_class", "NHibernate.Driver.SQLite20Driver"},
                {"dialect", "NHibernate.Dialect.SQLiteDialect"},
                {"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
                {"connection.connection_string", "Data Source=" + FileDB + ";locked=true"},
                {
                    "proxyfactory.factory_class",
                    @"NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"
                }
            };



            try
            {

                InPlaceConfigurationSource source = new InPlaceConfigurationSource();
                source.Add(typeof(ActiveRecordBase), properties);

                ActiveRecordStarter.Initialize(source, TestRequest_DBHelper.GetTypes());


            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());

            }
        }


        public void CreateDB(string FileDB)
        {
            try
            {

                InitDB(FileDB);

                ActiveRecordStarter.CreateSchema();

                tInfo otInfo = new tInfo();

                otInfo.Version_DB = Resources.Version_DB_01;

                otInfo.SaveAndFlush();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }


        }


    }
}
