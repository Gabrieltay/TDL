using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace ToDoListv2.Model
{
    public static class DataManager
    {
        public static bool CompareTwoLists<T>( IList<T> aList_1, IList<T> aList_2 )
        {
            if ( aList_1.Count != aList_2.Count )
                return false;

            Type eleType = typeof( T );
            for ( int index = 0; index < aList_1.Count; index++ )
            {
                foreach ( var propInfo in eleType.GetProperties() )
                {
                    if ( (propInfo.GetValue( aList_1[index], null )).Equals(
                        propInfo.GetValue( aList_2[index], null ) ) )
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }

        public static bool SaveListToFile<T>( IList<T> aList, String aFilename )
        {
            try
            {
                using ( Stream stream = File.Open( aFilename, FileMode.Create ) )
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize( stream, aList );
                    return true;
                }
            }
            catch ( IOException )
            {
                return false;
            }
        }

        public static List<T> GetListFromFile<T>( String aFilename )
        {
            List<T> nList = new List<T>();
            try
            {
                using ( Stream stream = File.Open( aFilename, FileMode.Open ) )
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    nList = (List<T>)bin.Deserialize( stream );
                }
            }
            catch ( IOException )
            {
            }
            return nList;
        }

    }
}
