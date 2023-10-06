using InformationSystem;

Console.Title = "Information system";

SystemInformation s = new SystemInformation(new Administrator("Adam", "Bartl", Student.Titles.Bc, "xbara", "123"), new Login());
s.AddStudent("Matěj", "Cajthaml", Student.Titles.Ing, "xcajt", "456");
s.AddTeacher("Marie", "Musiolková", Teacher.Titles.Mgr, "xmaria", "789");

s.LoginIntoSystem("xmaria", "789");
s.LoginIntoSystem("xcajt", "456");

