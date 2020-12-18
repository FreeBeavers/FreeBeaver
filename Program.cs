using System;

namespace CungHoangDaoV1
{
    class Program
    {
        static void Main(string[] args)
        {
                         Console.WriteLine("===================================================");
        //Nhap thong tin ca nhan
            Console.Write("Nhap Ho va Ten cua ban: ");
            string name = Console.ReadLine();

        //Nhap ngay thang nam 
            Console.Write("Nhap Day: ");
                int Day = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap Month: ");
                int Month = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap Year: ");
                int Year = System.Int32.Parse(Console.ReadLine());
        
        //Kiem tra dieu kien nhap dung du lieu 
            if(Month<0 || Month>12) {
                Console.WriteLine("Nhap sai! Vui long nhap lai");
            }
            if(Day<0 || Day>31){
                Console.WriteLine("Nhap sai! Vui long nhap lai");
            }
            if((Month == 1 ||Month == 3 ||Month == 5 ||Month == 7 ||Month == 8 ||Month == 10 ||Month == 12) && Day>31){
                Console.WriteLine("Nhap sai! Vui long nhap lai");
            }
            if((Month == 4 ||Month == 6 ||Month == 9 ||Month == 11 ) && Day>30){
                Console.WriteLine("Nhap sai! Vui long nhap lai");
            }
            if(Month==2){
                if(((Year%4==0 && Year%100!=0)||(Year%400==0)) && Day>29){
                        Console.WriteLine("Nhap sai! Vui long nhap lai");
                }else if(Day>28){
                        Console.WriteLine("Nhap sai! Vui long nhap lai");
                }
            }
        //Xac dinh cung dua theo thoi gian nhap vao
            string cungHoangDao="";
            if((Month ==3 && Day> 20)||(Month == 4 && Day<20)){
                cungHoangDao = "Bach Duong";
            }
            if((Month ==4 && Day> 19)||(Month == 5 && Day<21)){
                cungHoangDao = "Kim Nguu";
            }
            if((Month ==5 && Day> 20)||(Month == 6 && Day<22)){
                cungHoangDao = "Song Tu";
            }
            if((Month ==6 && Day> 21)||(Month == 7 && Day<23)){
                cungHoangDao = "Cu Giai";
            }
            if((Month ==7 && Day> 22)||(Month == 8 && Day<23)){
                cungHoangDao = "Su Tu";
            }
            if((Month ==8 && Day> 22)||(Month == 9 && Day<23)){
                cungHoangDao = "Su Nu";
            }
            if((Month ==9 && Day> 22)||(Month == 10 && Day<24)){
                cungHoangDao = "Thien Binh";
            }
            if((Month ==10 && Day> 23)||(Month == 11 && Day<20)){
                cungHoangDao = "Bo Cap";
            }
            if((Month ==11 && Day> 21)||(Month == 12 && Day<22)){
                cungHoangDao = "Nhan Ma";
            }
            if((Month ==12 && Day> 21)||(Month == 1 && Day<20)){
                cungHoangDao = "Ma Ket";
            }
            if((Month == 1 && Day> 19)||(Month == 2 && Day<19)){
                cungHoangDao = "Bao Binh";
            }
            if((Month ==2 && Day> 18)||(Month == 3 && Day<21)){
                cungHoangDao = "Song Ngu";
            }

        //In ra ket qua
            Console.WriteLine("===================================================");
            Console.WriteLine("Ho va ten: " + name +"\nVoi Ngay, Thang, Nam sinh la: " + Day+"/" + Month +"/" + Year +"\nCung Hoang Dao cua ban se la: " + cungHoangDao);
            Console.WriteLine("===================================================");
            Console.ReadLine();
        }
    }
}
