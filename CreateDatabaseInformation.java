package com.company;

import java.io.BufferedWriter;
import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.Random;

//Name:         Daniel Wilson
//Student ID:   1345359

//Custom coded program to allow for around 250,000 unique results to be created in SQL format for adding to the COMPX323
//Repairshop Database Program. Uses indexes into arrays with sections of strings to combine and create usernames, addresses,
//passwords etc as well as randomly generated values for dates.
class CreateDatabaseInformation {

  public static void main(String[] args) {
    CreateDatabaseInformation c = new CreateDatabaseInformation();
    c.Create();
  }
  public void Create() {
    //Used to store the
    ArrayList<String> output = new ArrayList<>();

    String[] FnamesP0 = {"Delma","Glory","Chi","Pearlene","Jeanelle","Beula","Delmer",
            "Donna","Giovanna","Caroline","Kindra","Piedad","Hyon","Hildred","Leida",
            "Domenic","Deann","Willena","Jude","Carina","Rich","Maida","Carmon","Rosaria",
            "Marcell","Moriah","Mac","Bernardina","Lorriane","Diane","Percy","Lila","Verda",
            "Trena","Britany","Kellee","Jolanda","Melaine","Lynnette","Rossana","Will",
            "Tabetha","Hattie","Gertie","Antione","Cammie","Aleshia","Esther","Andre"};

    String[] LnamesP0 = {"Franco","Pena","Wilcox","Cooper","Hawkins","Mcdaniel","Barker",
            "Owens","Hurst","Porter","Melendez","Sherman","Ray","Sharp","Houston",
            "Jefferson","Leblanc","Barajas","Rasmussen","Green","Dickson","Maida","Morrison","Barajas",
            "Newton","Chang","Herrera","Salazar","Chambers","Larson","Mcdowell","Curtis","Shelton",
            "Mahoney","Collier","Oneill","Wagner","Heath","Watkins","Brewer","Beasley",
            "Villa","Jenkins","Gertie","Vance","Ortega","Salazar","Cantrell","Cameron"};

    String[] StreetP0 = {"Chapel Hill","Chantry Close","Tudor Road","Birch Close","Heather Close","Ferry Lane","Park Place",
            "Arthur Street","Church View","School Hill","Ash Grove","Boundary Road","Sandy Lane","Byron Street","Newport Road",
            "Heron Close","Barley Close","Richmond Close","Rowan Drive","Silver Street","School Street","Bankside","Greenacres","The Paddocks",
            "Jasmine Close","Baker Street","Frog Lane","Cavendish Road","Second Avenue","Lower Road","Queensway","Kingsway","Rosemary Lane",
            "South Street","King Edward Road","Vicarage Close","Tower Road","Pear Tree Close","Lyndhurst Road","The Grange","Brookfield Road",
            "Derby Road","Vicarage Gardens","Willow Grove","Conway Road","Jackson Street","Railway Terrace","Devonshire Road","The Pastures"};

    String[] CityP0 = {"San Francisco", "Milwaukee", "Huntington", "Boise", "Scottsdale", "St. Louis", "Henderson", "Jersey City", "Greensboro", "Laredo",
            "Indianapolis", "Miami", "Omaha", "Arlington", "Memphis", "Chesapeake", "Cincinnati", "Fresno", "Columbus", "Riverside"};
    String[] PostCodeP0 = {"0091", "0693", "1456", "2987", "3412", "8208", "1237", "5487", "9034", "9492",
            "6574", "7398", "3584", "2869", "4583", "3256", "0687", "2347", "3486", "4568"};


    //An array of terms to be used for creating the model number

    String[] BrandP1 = {"APPLE", "MSI", "ACER", "ASUS", "SAMSUNG", "RAZOR", "LG"};

    String[] ModelP0 = {"Q-", "Z-", "Y-", "V-", "R-", "K-", "T-", "C-", "P-", "N-"};

    String[] ModelP1 = {"GX", "GW", "GM", "GP", "GD", "GS", "GH",
            "TX", "TW", "TM", "TP", "TD", "TS", "TH",
            "AX", "AW", "AM", "AP", "AD", "AS", "AH",
            "MX", "MW", "MM", "MP", "MD", "MS", "MH",
            "EX", "EW", "EM", "EP", "ED", "ES", "EH"};

    String[] ModelP2 = {"17", "10", "1G", "19", "18", "1Q", "14",
            "37", "30", "3G", "39", "38", "3Q", "34",
            "47", "40", "4G", "49", "48", "4Q", "44",
            "57", "50", "5G", "59", "58", "5Q", "54",
            "77", "70", "7G", "79", "78", "7Q", "74"};

    String[] ModelP3 = {"AF", "AX", "AG", "AT", "AN", "AQ", "AD",
            "BF", "BX", "BG", "BT", "BN", "BQ", "BD",
            "CF", "CX", "CG", "CT", "CN", "CQ", "CD",
            "EF", "EX", "EG", "ET", "EN", "EQ", "ED",
            "FF", "FX", "FG", "FT", "FN", "FQ", "FD"};

    //Used for creating passwords

    String[] PasswordP0 = {"Q", "Z", "Y", "V", "R", "K", "T", "C", "P", "N"};

    String[] PasswordP1 = {"FH7", "EF0", "GWG", "CD9", "AF8", "JMQ", "FV4",
            "DC7", "SD0", "FAG", "SW9", "AD8", "CDQ", "GR4",
            "UO7", "DW0", "YLG", "DW9", "AI8", "ZHQ", "44",
            "FS7", "ET0", "NUG", "DA9", "XS8", "YJQ", "AR4",
            "VG7", "GE0", "DEG", "JE9", "CS8", "EFQ", "SW4"};

    String[] PasswordP2 = {"351", "392", "3G3", "39H", "F8D", "3QS", "34V",
            "25J", "2SS", "2GQ", "29W", "28E", "2VF", "F4F",
            "35G", "39X", "3GD", "3Q", "68F", "3QW", "34F",
            "45E", "49V", "FGC", "4RD", "48S", "4QF", "4PG",
            "55J", "59S,", "IGH", "59T", "58S", "VQH", "54J"};

    String[] PasswordP3 = {"3SG1", "3GR2", "3GD3", "39FH", "FK8D", "3IQS", "34HV",
            "EG5J", "2CSS", "2DSQ", "2ASW", "EDFE", "SDFF", "F4FF",
            "4D5E", "4R9V", "FGHC", "4RDD", "48WS", "4QGF", "4WPG",
            "55WD", "HK9F", "5GSG", "7FBE", "U8DF", "5QEB", "54FN",
            "55SJ", "5Q9S,", "IGGH", "59TY", "5W8S", "VGQH", "54J"};

    //Used for creating Usernames

    String[] UserP0 = {"Blue", "Red", "Green", "Lazy", "Angry", "Sad", "Happy", "Scared", "Big", "Tiny"};

    String[] UserP1 = {"Mustang", "Chameleon", "Gazelle", "Deer", "Weasel", "Gorilla", "Bear",
            "Lamb", "Mandrill", "Hare", "Marten", "Puma", "Aoudad", "Fawn",
            "Snake", "Possum", "Wildcat", "Jerboa", "Bighorn", "Walrus", "Porcupine",
            "Woodchuck", "Budgerigar", "Wombat", "Cheetah", "Crab", "Platypus", "Toad",
            "Beaver", "Panther", "Baboon", "Dingo", "Stallion", "Vicuna", "Lynx"};

    String[] UserP2 = {"BLL", "BVG", "BGB", "BVH", "FWD", "BQS", "BLV",
            "GLJ", "GSS", "GGQ", "GVW", "GWE", "GVF", "FLF",
            "LYE", "LVV", "FGC", "LRD", "LWS", "LQF", "LPG",
            "ILD", "HVF", "LGG", "7BE", "UWF", "QEB", "LFN",
            "LLJ", "LVS", "IGH", "LVT", "LWS", "VQH", "LLJ"};


    //Used for creating phone numbers
    String[] PhoneP0 = {"(07)", "(06)", "(76)", "(47)", "(99)", "(01)", "(03)", "(53)", "(24)", "(31)", "(73)", "(48)", "(52)"};

    String[] PhoneP1 = {"832", "653", "063", "354", "742", "246", "194", "538", "552", "269", "542", "716", "493"};

    String[] PhoneP2 = {"32", "53", "63", "54", "42", "46", "94", "38", "52", "69", "42", "16", "93"};

    String[] PhoneP3 = {"23", "57", "03", "53", "40", "46", "04", "38", "82", "05", "43", "86", "33"};


    //Used to assign random email addresses
    String[] EmailP0 = {"@gmail.com", "@hotmail.com", "@slingshot.co.nz", "@icloud.com", "@yahoo.com", "@live.com"};

    int NUMBER = 250000;

    Random rand = new Random();
    //Sets the start year for generating random birthdates
    int StartYearDOB = 1950;
    //Start year for defining signup data / start work date
    int StartYearStore = 1985;
    //Start year for defining signup data / start work date
    int StartYearRepair = 2014;
    //For the default salary
    int defSal = 25;
    //Stores the word for incrementing the repair ID
    String autoIncrement = "Repair_seq.NEXTVAL";
    //Stores each of the strings for the created names
    ArrayList<String> Models = new ArrayList<>();
    ArrayList<String> Brands = new ArrayList<>();
    ArrayList<String> Passwords = new ArrayList<>();
    ArrayList<String> Users = new ArrayList<>();
    ArrayList<String> FNames = new ArrayList<>();
    ArrayList<String> LNames = new ArrayList<>();
    ArrayList<String> Customer = new ArrayList<>();
    ArrayList<String> Staff = new ArrayList<>();
    ArrayList<String> Streets = new ArrayList<>();
    ArrayList<String> Citys = new ArrayList<>();
    ArrayList<String> PostCodes = new ArrayList<>();
    ArrayList<String> Emails = new ArrayList<>();
    ArrayList<String> PhoneNums = new ArrayList<>();
    ArrayList<String> DOBs = new ArrayList<>();
    ArrayList<String> SignupDates = new ArrayList<>();
    ArrayList<String> HiringDates = new ArrayList<>();
    ArrayList<String> HourlySalarys = new ArrayList<>();
    ArrayList<String> RepairDates = new ArrayList<>();
    //First creates User account data
    int count = 0;
    for(int y = 0; y < PasswordP0.length; y++){
      for(int q = 0; q < PasswordP1.length; q++){
        for(int t = 0; t < PasswordP2.length; t++){
          for(int j = 0; j < PasswordP3.length; j++){
            count++;
            //Adds a unique data to the array using a combination of all fields
            Users.add(UserP0[y] + UserP1[q] + UserP2[t] + j);
            Passwords.add(PasswordP0[y] + PasswordP1[q] + PasswordP2[t] + PasswordP3[j]);
            Models.add(ModelP0[y] + ModelP1[q] + ModelP2[t] + ModelP3[j]);
            if (count == NUMBER){
              //Sets the loop to make 400,000 results, (200,000 for Customer and Staff)
              for(int i = 0; i < NUMBER; i++) {
                //Generates random date values
                int randomStreet = rand.nextInt(48);
                int randomNumber = rand.nextInt(125) + 1;
                int randomCity = rand.nextInt(19);
                int randomBrand = rand.nextInt(6);
                int randomDOBYear = rand.nextInt(50);
                int randomDOBMonth = rand.nextInt(12) + 1;
                int randomDOBDay = rand.nextInt(29) + 1;
                int randomRepairYear = rand.nextInt(4);
                int randomRepairMonth = rand.nextInt(12) + 1;
                int randomRepairDay = rand.nextInt(29) + 1;
                int randomEmailProvider = rand.nextInt(5);
                int randomPH0 = rand.nextInt(12);
                int randomPH1 = rand.nextInt(12);
                int randomPH2 = rand.nextInt(12);
                int randomPH3 = rand.nextInt(12);
                int randomFName = rand.nextInt(33);
                int randomLName = rand.nextInt(33);
                FNames.add(FnamesP0[randomFName]);
                LNames.add(LnamesP0[randomLName]);
                //Creates an address to add, also adds a random city and post code
                Streets.add(randomNumber + " " + StreetP0[randomStreet]);
                Citys.add(CityP0[randomCity]);
                PostCodes.add(PostCodeP0[randomCity]);
                //Adds the brand
                Brands.add(BrandP1[randomBrand]);
                StringBuilder DOB = new StringBuilder();
                DOB.append(randomDOBYear + StartYearDOB);
                DOB.append("/");
                DOB.append(randomDOBMonth);
                DOB.append("/");
                DOB.append(randomDOBDay);
                DOBs.add(DOB.toString());
                StringBuilder RepairDate = new StringBuilder();
                int repairYear = randomRepairYear + StartYearRepair;
                RepairDate.append(repairYear);
                RepairDate.append("/");
                RepairDate.append(randomRepairMonth);
                RepairDate.append("/");
                RepairDate.append(randomRepairDay);
                RepairDates.add(RepairDate.toString());
                //Creates a email using the users username and randomEmailProvider
                Emails.add(Users.get(i) + EmailP0[randomEmailProvider]);
                PhoneNums.add(PhoneP0[randomPH0] + PhoneP1[randomPH1] + PhoneP2[randomPH2] + PhoneP3[randomPH3]);
                //Creates the Customer and Staff member data
                //Works out if a employee or customer needs to be created
                if((i % 10) == 0){
                  int randomEmployYear = rand.nextInt(18);
                  int randomEmployMonth = rand.nextInt(12) + 1;
                  int randomEmployDay = rand.nextInt(29) + 1;
                  //Creates a random salary between $25 and $40
                  int randomSalary = rand.nextInt(15);
                  Staff.add(Users.get(i));
                  StringBuilder HiringDate = new StringBuilder();
                  HiringDate.append(randomEmployYear + StartYearStore);
                  HiringDate.append("/");
                  HiringDate.append(randomEmployMonth);
                  HiringDate.append("/");
                  HiringDate.append(randomEmployDay);
                  HiringDates.add(HiringDate.toString());
                  HourlySalarys.add(randomSalary + defSal + "");
                }
                else {
                  int randomSignupYear = rand.nextInt(13);
                  int randomSignupMonth = rand.nextInt(12) + 1;
                  int randomSignupDay = rand.nextInt(29) + 1;
                  Customer.add(Users.get(i));
                  StringBuilder Signup = new StringBuilder();
                  Signup.append(randomSignupYear +1995);
                  Signup.append("/");
                  Signup.append(randomSignupMonth);
                  Signup.append("/");
                  Signup.append(randomSignupDay);
                  SignupDates.add(Signup.toString());
                }
              }
              //Gets the length of the Customers and Staff
              int StaffNumber = Staff.size();
              int CustomerNumber = Customer.size();
              int RepairDatesNumber = RepairDates.size();
              int ModelsNum = Models.size();
              int UsersNum = Users.size();
              System.out.println("");
              for(int d = 0; d < ModelsNum; d++) {
                output.add("INSERT INTO DeviceModel VALUES ('" + Models.get(d) + "', '" + Brands.get(d) + "');");
              }
              System.out.println("");
              for(int u = 0; u < UsersNum; u++) {
                output.add("INSERT INTO UserAccount VALUES ('" + Users.get(u) + "', '" + Passwords.get(u) + "', '" + FNames.get(u) + "', '" + LNames.get(u) + "', '" + PhoneNums.get(u)
                        + "', '" + Emails.get(u) + "', '" + Streets.get(u) + "', '" + Citys.get(u) + "', '" + PostCodes.get(u) + "', to_date('" + DOBs.get(u) + "', 'yyyy/mm/dd'));");
              }
              System.out.println("");
              for(int s = 0; s < StaffNumber; s++) {
                output.add("INSERT INTO Staff VALUES ('" + Staff.get(s) + "', '" + HourlySalarys.get(s) + "', to_date('" + HiringDates.get(s) + "', 'yyyy/mm/dd'));");
              }
              System.out.println("");
              for(int c = 0; c < CustomerNumber; c++) {
                output.add("INSERT INTO Customer VALUES ('" + Customer.get(c) + "', to_date('" + SignupDates.get(c) + "', 'yyyy/mm/dd'));");
              }
              System.out.println("");
              for(int r = 0; r < RepairDatesNumber; r++){
                //Gets a random staff member and customer index for the
                int RandomStaffIndex = rand.nextInt(StaffNumber);
                int RandomCustomerIndex = rand.nextInt(CustomerNumber);
                output.add("INSERT INTO RepairJob VALUES (Repair_seq.NEXTVAL, to_date('" + RepairDates.get(r) + "', 'yyyy/mm/dd'), '" + Customer.get(RandomCustomerIndex) + "', '" + Staff.get(RandomStaffIndex)
                        + "', '" + Models.get(r) + "');");
              }
              try{
                FileWriter writer = new FileWriter("outDataBaseData.sql", true);
                for (int l = 0; l < output.size(); l++) {
                  writer.write(output.get(l) + "\n");
                }
                writer.close();
              }
              catch (Exception e){
                System.out.print("Error encountered: ");
                e.printStackTrace();
              }
            }
          }
        }
      }
    }
  }
}
