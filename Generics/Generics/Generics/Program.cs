using System;


namespace Generics
{ 
    class Program
    {
        private const string pathFurniture = @"D:\EPAM_LABA\HomeTasks\Generics\data_Furniture.json";
        private const string pathNewFileFurniture = @"D:\EPAM_LABA\HomeTasks\Generics\result_data_Furniture.json";
        private const string pathPerson = @"D:\EPAM_LABA\HomeTasks\Generics\data_Person.json";
        private const string pathNewFilePerson = @"D:\EPAM_LABA\HomeTasks\Generics\result_data_Person.json";

        static void Main(string[] args)
        {
            var f = new Furniture { Type = "Table", Count = 5 };
            var p = new Person { Name = "Jhon", Age = 33};

            Input.InputData(f, pathFurniture);
            var tempF = FileReader.DecreaseCount<Furniture>(pathFurniture);
            Input.InputData(tempF, pathNewFileFurniture);

            Input.InputData(p, pathPerson);
            var tempP = FileReader<Person>.IncreaseAge(pathPerson);
            Input.InputData(tempP, pathNewFilePerson);
        }
    }
}
