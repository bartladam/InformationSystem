using InformationSystem;

SystemInformation s = new SystemInformation(new Administrator("Adam", "Bartl", Student.Titles.Bc, "xbara", "123"), new Login());
s.AddStudent("Matěj", "Cajthaml", Student.Titles.Ing, "xcajt", "456");
s.LoginIntoSystem("xcajt", "456");