using System.Reflection;
using _27DBAttributeLib;

namespace _25ReflectionCreateTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string assemblyPath = @"C:\240845920024\DotNet\26EmpLib\bin\Debug\net6.0\26EmpLib.dll";
            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type[] types = asm.GetTypes();
            string MySQLQuery = "Create table ";
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                if (type.IsPublic)
                {
                    Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                    for (int j = 0; j < allAttributes.Length; j++)
                    {
                        Attribute attributeOfClasses = allAttributes[j];
                        if (attributeOfClasses is Table)
                        {
                            Table currentTable = attributeOfClasses as Table;
                            MySQLQuery = MySQLQuery + currentTable.TableName + " ( ";
                      
                        }
                    }
                    PropertyInfo[] allProperties = type.GetProperties();
                    for (int j = 0; j < allProperties.Length; j++)
                    {
                        PropertyInfo prop = allProperties[j];
                        Attribute[] attributeOfProperties = prop.GetCustomAttributes().ToArray();
                        for (int k = 0; k < attributeOfProperties.Length; k++)
                        {
                            Attribute propAttributes = attributeOfProperties[k];
                            if (propAttributes is Column)
                            {
                                Column column = propAttributes as Column;
                                MySQLQuery = MySQLQuery + column.ColumnName + " " +
                                                            column.ColumnType + ",";
                            
                            }
                        }
                    }
                }
            }

            MySQLQuery = MySQLQuery.TrimEnd(',') + " );";
            Console.WriteLine(MySQLQuery);

            string filePath = @"C:\240845920024\DotNet\query.sql";
            using (StreamWriter write = File.AppendText(filePath))
            {
                write.WriteLine(MySQLQuery);
                Console.WriteLine("MySql script wrtting task done!");
            }
        }
    }
}