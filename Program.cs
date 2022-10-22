using System;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Threading;

class Program
{
  static void Main()
  {
    Console.Title = "MiniBash"; Console.ForegroundColor = ConsoleColor.White;
    

    bool closE = false;

    Directory.CreateDirectory(@"$");

    string pwd = @"$";

    string[] DIRS = Directory.GetDirectories(pwd);
    string[] FILES = Directory.GetFiles(pwd);


while(closE == false){   
    
    Console.ForegroundColor = ConsoleColor.Cyan; Console.Write($"{pwd}>"); Console.ForegroundColor = ConsoleColor.White;

    switch(Console.ReadLine())
    {
      case "ls" :    try {
      
                     DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                     Console.WriteLine(); 
                   
                     Console.ForegroundColor = ConsoleColor.Blue; for(int i = 0; i < DIRS.Length; i++){ var infoDIR = new DirectoryInfo(DIRS[i]); Console.WriteLine(infoDIR.Name); } 
                     Console.ForegroundColor = ConsoleColor.White; for(int j = 0; j < FILES.Length; j++){ var infoFILE = new FileInfo(FILES[j]); Console.WriteLine(infoFILE.Name); }
                   
                         }

                   catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                   catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}

                   Console.WriteLine();
      break;





      case "ls -l" :   try {
      
                       DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                       Console.WriteLine();
                     
                       Console.ForegroundColor = ConsoleColor.Blue; foreach(string dir in DIRS){Console.WriteLine(dir);}
                     
                       Console.ForegroundColor = ConsoleColor.White; foreach(string file in FILES){Console.WriteLine(file);}

                           }

                     catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                     catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}
                     
                     Console.WriteLine();
      break;





      case "ls -lf" :  try {
      
                       DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                       Console.WriteLine(); foreach(string file in FILES){Console.WriteLine(file);} Console.WriteLine();
                      
                           }

                      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                      
                      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      break;





      case "ls -f" :   try {
      
                       DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                       Console.WriteLine(); for(int j = 0; j < FILES.Length; j++){ var infoFILE = new FileInfo(FILES[j]); Console.WriteLine(infoFILE.Name); } Console.WriteLine();
                     
                           }

                     catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
                     catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}               
      break;




      case "ls -lr" :  try {
      
                       DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                       Console.WriteLine();
                          
                       Console.ForegroundColor = ConsoleColor.Blue; foreach(string dir in DIRS){Console.WriteLine(dir);} Console.ForegroundColor = ConsoleColor.White;
                          
                           }

                          catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                          catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}

                          Console.WriteLine();
      break;





      case "ls -r" : try {
      
                     DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                     Console.WriteLine();
                     
                     Console.ForegroundColor = ConsoleColor.Blue; for(int i = 0; i < DIRS.Length; i++){ var infoDIR = new DirectoryInfo(DIRS[i]); Console.WriteLine(infoDIR.Name); } Console.ForegroundColor = ConsoleColor.White;

                         }

                     catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                     catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}
                     
                     Console.WriteLine();
      break;




                      
      case "ls -n" :  try {
      
                      DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
      
                      Console.WriteLine();
       
                      Console.ForegroundColor = ConsoleColor.Blue; for(int i = 0; i < DIRS.Length; i++){ var infoDIR = new DirectoryInfo(DIRS[i]); Console.WriteLine(infoDIR.Name); } 
                      Console.ForegroundColor = ConsoleColor.White; for(int j = 0; j < FILES.Length; j++){ var infoFILE = new FileInfo(FILES[j]); Console.WriteLine(infoFILE.Name); }
                      Console.WriteLine();  Console.WriteLine($"{DIRS.Length} Directories"); Console.WriteLine();  Console.WriteLine($"{FILES.Length} Files"); Console.WriteLine();
      
                          }

                      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}
                      
                      Console.WriteLine();                 
     break;





      case "ls -ln" : try {
      
                      DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
                      
                      Console.WriteLine();
       
                      Console.ForegroundColor = ConsoleColor.Blue; foreach(string dir in DIRS){Console.WriteLine(dir);}
                      Console.ForegroundColor = ConsoleColor.White; foreach(string file in FILES){Console.WriteLine(file);}
                      Console.WriteLine();  Console.WriteLine($"{DIRS.Length} Directories"); Console.WriteLine();  Console.WriteLine($"{FILES.Length} Files"); Console.WriteLine();
      
                          }

                      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.ForegroundColor = ConsoleColor.White;}

                      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.ForegroundColor = ConsoleColor.White;}
                      
                      Console.WriteLine();                
      break;





      case "cd" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Type another directory to work on!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      
      pwd = Console.ReadLine();    Console.WriteLine();
      
                        try {
                         
                        DIRS = Directory.GetDirectories(pwd); FILES = Directory.GetFiles(pwd);
                         
                            }
      
      catch (DirectoryNotFoundException){pwd = @"$"; Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Directory not found!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (UnauthorizedAccessException) {pwd = @"$"; Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {pwd = @"$"; Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "cd ~" : pwd = @"$";
      break;





      case "touch" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where do you want to create the file? (PATH + FILENAME)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      
      string toucH = Console.ReadLine(); 
      
                        try{
      
                    File.Create(toucH).Close(); Console.WriteLine();
      
                           }

      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppps! it seems like you either don't have enough privileges, or forgot to add the FILENAME!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "rm" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Which file do you want to remove? (PATH + FILENAME)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      
      string RM = Console.ReadLine(); 
      
                        try {

                    bool rmEXIST = File.Exists(RM); if (rmEXIST == false) {throw new FileNotFoundException(RM);}

                    File.Delete(RM);
                    
                    Console.WriteLine();
                            
                            }

      catch (FileNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("No such file!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Oppsss! It seems like the file you're trying to remove is currently being used by another process!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "mkdir" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where do you want to create the directory? (PATH + DIRNAME)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White; 
      
      string dirCreatePATH = Console.ReadLine();
      
                        try {

                    Directory.CreateDirectory(dirCreatePATH);
                    
                    Console.WriteLine();
                    
                            
                            }

      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "rm -r" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Which Directory do you want to remove? (PATH + DIRNAME)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      
      string dirREMOVE = Console.ReadLine();
      
                        try {
                         
                    Directory.Delete(dirREMOVE, true);

                    Console.WriteLine();

                            }

      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();}
      
      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like the directory you're trying to remove is being used by another process!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      break;





      case "rmdir" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Which Directory do you want to remove? (PATH + DIRNAME)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      
      dirREMOVE = Console.ReadLine();
      
                        try {
      
                    Directory.Delete(dirREMOVE, true);
                      
                    Console.WriteLine();
                     
                            }

      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("No such directory!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like the directory you're trying to remove is being used by another process!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      break;





      case "mv" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where's your file?"); Console.ForegroundColor = ConsoleColor.White;   string MVcurrent = Console.ReadLine();
                  Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Where do you want to move it? (DESTINATION)"); Console.ForegroundColor = ConsoleColor.White;   string MVdest = Console.ReadLine();
                  
                           try {

                    var fileName = new FileInfo(MVcurrent);

                    File.Move(MVcurrent, $"{MVdest + @"\"} {fileName.Name}"); 
                    
                    Console.WriteLine();

                               }
                  
      catch (FileNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("File not found!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                  
      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Directory not found!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                  
      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like the file you're trying to move is being used by another process"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                  
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "mv -r" :  Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where's the directory you want to move?"); Console.ForegroundColor = ConsoleColor.White; string MVDIRcurrent = Console.ReadLine();
                      Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Where do you want to move it? (DESTINATION)"); Console.ForegroundColor = ConsoleColor.White; string MVDIRdest = Console.ReadLine();
                      
                        try {

                    var dirname = new DirectoryInfo(MVDIRcurrent);
                    
                    Directory.Move(MVDIRcurrent + @"\", $"{MVDIRdest + @"\"}{dirname.Name}"); Console.WriteLine();
                    
                            }
                      
      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("No such directory!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                      
      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                      
      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like the directory you're trying to move is being used by another process"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
                      
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "cp" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where's the file you want to copy?"); Console.ForegroundColor = ConsoleColor.White;   string copyFILEsource = Console.ReadLine();
                  Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Where do you want to copy it? (DESTINATION)"); Console.ForegroundColor = ConsoleColor.White;   string copyFILEdest = Console.ReadLine();

                        try { 

      var infoFILEcopy = new FileInfo(copyFILEsource);

      File.Copy (copyFILEsource, $"{copyFILEdest + @"\"}{infoFILEcopy.Name}");
      
      Console.WriteLine();
      
                            }

      catch (FileNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("File not found!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("No such directory!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (IOException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like either the file already exists, or it's being used by another process"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "cp -r" : Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Where's the directory you want to copy?"); Console.ForegroundColor = ConsoleColor.White; string cpDIRsource = Console.ReadLine();
                     Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Where do you want to copy it? (DESTINATION)"); Console.ForegroundColor = ConsoleColor.White; string cpDIRdest = Console.ReadLine();

                        try {

      var cpDIRinfo = new DirectoryInfo(cpDIRsource);

      DirectoryInfo[] dirs = cpDIRinfo.GetDirectories();
                     
      Directory.CreateDirectory($@"{cpDIRdest}\{cpDIRinfo.Name}"); Console.WriteLine();
                            
                           

      foreach (FileInfo file in cpDIRinfo.GetFiles())
         {
            string targetFilePath = Path.Combine($@"{cpDIRdest}\{cpDIRinfo.Name}"  , file.Name);
            file.CopyTo(targetFilePath);
         }

                            }
      

      catch (DirectoryNotFoundException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("The directory doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (UnauthorizedAccessException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems you don't have enough privileges for that!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      catch (ArgumentException) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like you used an illegal character!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}
      
      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

      break;





      case "open" : OpenFiles();
      break;





      case "neofetch" : Console.ForegroundColor = ConsoleColor.Cyan; Neofetch(); 

      Console.WriteLine("=================================================================================================");
      
      Console.ForegroundColor = ConsoleColor.White;

      Console.Write("Motherboard: "); HardwareINFO("Win32_BaseBoard", "Manufacturer"); Console.Write(" "); HardwareINFO("Win32_BaseBoard", "Product"); Console.WriteLine();
      Console.Write("CPU: "); HardwareINFO("Win32_Processor","Name"); Console.WriteLine();
      Console.Write("GPU: "); HardwareINFO("Win32_VideoController", "Name"); Console.WriteLine();
      Console.Write("RAM: "); Console.Write("Brand: "); HardwareINFO("Win32_PhysicalMemory", "Manufacturer"); Console.Write("        Capacity: "); HardwareINFO("Win32_PhysicalMemory", "Capacity"); Console.Write("        Speed: "); HardwareINFO("Win32_PhysicalMemory", "Speed"); Console.WriteLine();
      Console.Write("Windows Version: "); HardwareINFO("Win32_OperatingSystem", "Version"); Console.WriteLine();
      
      Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("================================================================================================="); Console.ForegroundColor = ConsoleColor.White;
      break;





      case "clear" : Console.Clear();
      break;





      case "exit" : Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan; BYE(); Thread.Sleep(2000);  closE = true;
      break;





      case "help" : Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Commands:\r\n\r\n1- ls: lists your directories and files\r\n\r\n2- ls -l: lists your directories and files, but also outputs their path\r\n\r\n3- ls -lf: lists ONLY your files, outputting their path\r\n\r\n4- ls -f: lists ONLY your files\r\n\r\n5- ls -lr: lists ONLY your directories, outputting their path\r\n\r\n6- ls -r: lists ONLY your directories\r\n\r\n7- ls -n: lists your directories and files, but also counts the amount of folders and files that you have\r\n\r\n8- ls -ln: lists your directories and files, outputs their path and counts the amount of folders and files\r\n\r\n9- cd: changes the working directory\r\n\r\n10- cd ~: comes back to the default folder\r\n\r\n11- touch: creates files\r\n\r\n12- rm: removes files\r\n\r\n13- mkdir: create directories\r\n\r\n14- rm -r: delete directories\r\n\r\n15- rmdir: delete directories\r\n\r\n16- mv: move files\r\n\r\n17- mv -r: move directories\r\n\r\n18- cp: copy files\r\n\r\n19- cp -r: copy directories\r\n\r\n20- open: open a file\r\n\r\n21- neofetch: cool stuff happens!\r\n\r\n22- clear: it cleans your mess (*lenny face*)\r\n\r\n23- exit: it means bye bye!\r\n\r\n24- sourceC: allows you to see the potato code that i wrote (cuz why not lol)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      break;





      case "sourceC" : Console.ForegroundColor = ConsoleColor.Magenta; SourceCode.SourceC(); Console.ForegroundColor = ConsoleColor.White;
      break;





      case "" : Console.Write("");
      break;





      default : Console.ForegroundColor = ConsoleColor.Magenta;  Console.WriteLine(); Console.WriteLine("COMMAND NOT FOUND!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
      break;
    }
}

  }

  static void OpenFiles()
  {

   Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(); Console.WriteLine("Which file do you wish to open? (PATH OF THE FILE)"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
   
   string notepad = @"\Windows\notepad.exe";
   string WindowsMedia = @"\Program Files\Windows Media Player\wmplayer.exe";
   string Edge = @"\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

   string fileToOpen = Console.ReadLine();

   bool existFILE = File.Exists(fileToOpen);


                        try {


       if (existFILE == false) {throw new FileNotFoundException(fileToOpen);}

       if (existFILE == true)
       
          {
   
   if (fileToOpen.Contains(".exe")){Process.Start(fileToOpen);}
   if (fileToOpen.Contains(".zip")){Process.Start(fileToOpen); Console.WriteLine();}
   




   if (fileToOpen.Contains(".txt")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".me")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".c")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".js")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".html")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".asp")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".rpy")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".php")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".lua")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".vbs")){Process.Start(notepad, fileToOpen); Console.WriteLine();}
   
   



   if (fileToOpen.Contains(".mp3")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".midi")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".wav")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".aac")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".flac")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".ogg")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".aiff")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}





   if (fileToOpen.Contains(".mp4")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".webm")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".mov")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".mkv")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".wmv")){Process.Start(WindowsMedia, fileToOpen); Console.WriteLine();}





   if (fileToOpen.Contains(".png")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".jpg")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".jpeg")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".webp")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".raw")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".bmp")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".tiff")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".ico")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
   
   if (fileToOpen.Contains(".gif")){Process.Start(Edge, fileToOpen); Console.WriteLine();}
       
          }
   
                            }

      catch (FileNotFoundException){Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("File doesn't exist!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}

    
      catch (System.ComponentModel.Win32Exception) //if the user's notepad, windows media player or edge installations are not in the default path
      {
     
      Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It Seems like the app that would be used to open this file (e.g notepad, windows media player, etc.) is not on the expected location!"); Console.WriteLine();
      Console.WriteLine("TYPE ANOTHER LOCATION FOR THIS APP!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;

      string changeAPP = Console.ReadLine();
      Console.WriteLine();
      Process.Start(changeAPP, fileToOpen);
     
      }

      catch (Exception) {Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(); Console.WriteLine("Oppss! It seems like something went wrong!"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;}


  }

  static void Neofetch()
  {
    string neofetch = @"                                ..,
                    ....,,:;+ccllll
      ...,,+:;  cllllllllllllllllll
,cclllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
                                   
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
llllllllllllll  lllllllllllllllllll
`'ccllllllllll  lllllllllllllllllll
       `' \*::  :ccllllllllllllllll
                       ````''*::cll
                                 ``";

   Console.WriteLine(neofetch);

  }

  static void BYE()
  {
    string BYEMeSSAGE = 
    @"
11111                         _______     _______           1111111111111111                  1000001
1000011111                      100         001             1000100000000001                  1000001
100000000111111                  100       001              1000100000000001                  1000001
1000000000000001                  100     001               1000111111111111                  1000001
100000000001111                    100   001                10001                             1000001
1000001                             100 001                 10001111111                       1000001
1000001111111                        10001                  10001000001                       1000001
100000000000011111                    101                   10001111111                       1000001
1000000000000000001                   101                   10001                             1000001
100000000000000011                    101                   10001                             1111111
1000000000000001                      101                   10001
100000000000111                       101                   1000111111111111                  1111111
100000000001                          101                   1000100000000001                  1000001
10000001111                           101                   1000000000000001                  1000001
 111111                               101                   1111111111111111                  1111111";
    
 
     Console.WriteLine(BYEMeSSAGE);
  }

  static void HardwareINFO(string hwclass, string syntax)
  {

   ManagementObjectSearcher hardINFO = new ManagementObjectSearcher("root\\CIMV2", "Select * FROM " + hwclass);
   foreach (ManagementObject info in hardINFO.Get())
   {
    Console.Write(Convert.ToString(info[syntax]));
   }
 
  }

}