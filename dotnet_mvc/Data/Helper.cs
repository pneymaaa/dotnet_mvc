using System.ComponentModel;
using System.Data;
using dotnet_mvc.Models;

namespace dotnet_mvc.Data
{
    public static class Helper
    {
        public static string CreateRandomName(this Random rd, (int Min, int Max)length)
        {
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
            (int min, int max) = length;
            char[] chars = new char[max];
            int stringLength = rd.Next(min, max + 1);
            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[rd.Next(allowedChars.Length)];
            }
            return new string(chars,0,stringLength);
        }

        public static tblM_Gender CreateRandomGender(this Random rd)
        {
            var gender = new tblM_Gender();
            int randomId = rd.Next(1,3);
            if(randomId == 1)
            {
                gender.Id = 1;
                gender.Name = "Pria";
            } else if(randomId == 2) {
                gender.Id = 2;
                gender.Name = "Wanita";
            }
            return gender;
        }

        public static tblM_Hobby CreateRandomHobby(this Random rd)
        {
            var hobby = new tblM_Hobby();
            int randomId = rd.Next(1,6);
            if(randomId == 1)
            {
                hobby.Id = 'A';
                hobby.Name = "Sepak Bola";
            } else if(randomId == 2)
            {
                hobby.Id = 'B';
                hobby.Name = "Badminton";
            } else if(randomId == 3) 
            {
                hobby.Id = 'C';
                hobby.Name = "Tenis";
            } else if(randomId == 4) 
            {
                hobby.Id = 'D';
                hobby.Name = "Renang";
            } else if(randomId == 5) 
            {
                hobby.Id = 'E';
                hobby.Name = "Bersepeda";
            }
            return hobby;
        }

        public static DataTable? ToDataTable<T>(this List<T> data)
        {
            PropertyDescriptorCollection properties = 
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
