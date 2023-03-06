class FileReader 
{
    public List<Staff> ReadFile() 
    {
        List<Staff> myStaff = new List<Staff>();
        string[] result = new string[2];
        string path = "staff.txt";
        string[] separator = {", "};

        if (File.Exists(path)) 
        {
            using (StreamReader sr = new StreamReader(path)) 
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    result = line.Split(separator[0]);
                    
                    if (result[1].ToLower() == "manager") 
                    {
                        Manager newManager = new Manager(result[0]);
                        myStaff.Add(newManager);    
                    }
                    else if (result[1].ToLower() == "admin") 
                    {
                        Admin newAdmin = new Admin(result[0]);
                        myStaff.Add(newAdmin);    
                    }
                    else 
                    {
                        Staff newStaff = new Staff(result[0]);
                        myStaff.Add(newStaff);
                    }
                }

                sr.Close();
            }
            return myStaff;
        }
        else 
        {
            Console.WriteLine("Input file 'staff.txt' could not be found!");
            return null;
        }   
    }
}