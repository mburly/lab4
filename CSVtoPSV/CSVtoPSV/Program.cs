namespace CSVtoPSV
{
    public class Program
    {
        public static string ParseFirstLine(StreamReader sr)
        {
            string[] line = sr.ReadLine().Split(',');
            string firstName = line[0];
            string lastName = line[1];
            string address = line[3];
            string city = line[4];
            string state = line[6];
            string zip = line[7];
            string phone1 = line[8];
            string phone2 = line[9];
            return $"{firstName}|{lastName}|{address}|{city}|{state}|{zip}|{phone1}|{phone2}"; 
        }
        public static Phone ParsePhone(string phone)
        {
            int areaCode = Int32.Parse(phone.Substring(1, 3));
            int exchangeCode = Int32.Parse(phone.Substring(5, 3));
            int lineNumber = Int32.Parse(phone.Substring(9, 4));
            Phone p = new Phone(1, areaCode, exchangeCode, lineNumber, phone);
            return p;
        }
        public static void Main(string[] args)
        {
            string inputPath = FileRoot.Root + "/data.csv";
            string outputPath = FileRoot.Root + "/data.psv";
            using (StreamReader sr = new StreamReader(inputPath))
            {
                try
                {
                    string header = ParseFirstLine(sr);
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        writer.WriteLine(header);
                        while (!sr.EndOfStream)
                        {
                            string input = sr.ReadLine();
                            string[] info = input.Split(',');

                            string firstName = info[0];
                            string lastName = info[1];
                            string a = info[3];
                            string city = info[4];
                            string state = info[6];
                            string zipCode = info[7];
                            string p1 = info[8];
                            string p2 = info[9];

                            // In the case of a comma being in the address, we have to increase the index by 1.
                            if (a[0] != '"')
                            {
                                a = info[4];
                                city = info[5];
                                state = info[7];
                                zipCode = info[8];
                                p1 = info[9];
                                p2 = info[10];

                            }
                            Phone phone1 = ParsePhone(p1);
                            Phone phone2 = ParsePhone(p2);

                            // Parsing the address
                            a = a.Trim('"');
                            int number;
                            Int32.TryParse(a.Split(' ')[0], out number);
                            string street = a.Replace(number.ToString(), "").Trim();
                            Address address = new Address(number, street, city, state, zipCode);

                            Person p = new Person(firstName, lastName, address, phone1, phone2);
                            writer.WriteLine(p.ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}