using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SchetBanka;

namespace SchetBanka
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<SchetVBanke> scheta = new List<SchetVBanke>();

            //   for (int i = 0; i < scheta.Count; i++)
            //   {

            //      scheta[i] = new SchetVBanke();


            //  }
            string otvet1;

            int otvetSchet = 1;
            //  SchetVBanke schet = new SchetVBanke();
            //  scheta.Add(schet);
            int otvetMenu = 1;
            int nomer;
            while (otvetSchet == 0 || otvetSchet == 1 )
            {
                Console.WriteLine("Введите 1, чтобы создать новый счет или введите 0, чтобы перейти в меню уже существующего");
                otvetSchet = Convert.ToInt32(Console.ReadLine());

                if (otvetSchet == 1)
                {
                    SchetVBanke schet = new SchetVBanke();
                    scheta.Add(schet);
                    otvetSchet = 0;
                    nomer = scheta.IndexOf(schet) + 1;

                }

                else if (otvetSchet == 0)
                {
                    Console.WriteLine("У вас " + scheta.Count + " счетов ");
                    Console.WriteLine("Введите номер (1, 2...) счета, в меню которого хотите перейти");
                    nomer = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }

                for (int i = 0; i < scheta.Count; i++)
                {
                    if (nomer == i + 1)
                    {

                        otvetMenu = 1;
                        
                        while (otvetMenu >= 1 && otvetMenu < 7)
                        {

                            Console.WriteLine("Меню счета " + (i + 1) + ": \n 1 - заполнить информацию счета \n 2 - показать информацию о счете \n 3 - положить на счет \n 4 - снять со счета \n 5 - взять всю сумму \n 6 - перенести сумму с одного счета на другой" +
                                  " \n 7 - перейти в меню другого счета или создать новый");
                            otvetMenu = Convert.ToInt32(Console.ReadLine());
                            switch (otvetMenu)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    scheta[i].choose(otvetMenu);
                                    break;
                                case 6:
                                    Console.WriteLine("Введите номер счета (1, 2...), на который хотите перевести сумму с этого");
                                    nomer = Convert.ToInt32(Console.ReadLine());
                                    bool check = false;
                                    for (int j = 0; j < scheta.Count; j++)
                                    {
                                        if (nomer == j + 1)
                                        {
                                            check = true;
                                            scheta[i].choose(scheta[j], otvetMenu);
                                            break;

                                        }

                                    }
                                    if (check == false)
                                    {
                                        Console.WriteLine("Такого счета нет");
                                        break;
                                    }
                                    break;
                                case 7:
                                    break;
                                    // Console.WriteLine("У вас " + scheta.Count + " счетов ");
                                    // Console.WriteLine("Введите номер (1, 2...) счета, в меню которого хотите перейти");
                                    // nomer = Convert.ToInt32(Console.ReadLine());
                                    break;

                                    //  break;


                            }

                            //  Console.WriteLine("Хотите вернуться в меню счета №" + otvetSchet + "?");
                            //   otvet1 = Console.ReadLine();
                            //  if (otvet1 == "нет")
                            //  {
                            //      break;
                            // Console.WriteLine(""); 
                            //  }

                        //    if (otvetMenu == 7)
                         //   {

                        //        break;
                         //   }
                        }
                       
                    }
                    else
                    {
                        continue;
                    }

                 //   if (otvetMenu == 7)
                  //  {

                  //      break;
                  //  }


                }



                //    int otvetMenu = 1;
                //  otvet1 = "да";
                /*      while (otvetMenu >= 1 && otvetMenu < 7)
                      {

                          Console.WriteLine("Меню счета " + otvetSchet + ": \n 1 - заполнить информацию счета \n 2 - показать информацию о счете \n 3 - положить на счет \n 4 - снять со счета \n 5 - взять всю сумму \n 6 - перенести сумму с одного счета на другой" +
                              " \n 7 - перейти в меню другого счета или создать новый");
                          otvetMenu = Convert.ToInt32(Console.ReadLine());
                          switch (otvetMenu)
                          {
                              case 1:
                              case 2:
                              case 3:
                              case 4:
                              case 5:
                                  scheta[otvetSchet - 1].choose(otvetMenu);
                                  break;
                              case 6:
                                  switch (otvetSchet - 1)
                                  {
                                      case 0:
                                          scheta[0].choose(scheta[1], otvetMenu);
                                          break;
                                      case 1:
                                          scheta[1].choose(scheta[0], otvetMenu);
                                          break;
                                  }
                                  break;
                              case 7:
                                  // Console.WriteLine("");
                                  break;
                              default: break;

                          }
                      }



                  if (otvetSchet == 0)
                  {
                      Console.WriteLine("У вас " + scheta.Count + " счетов ");
                      Console.WriteLine("Введите номер (1, 2...) счета, в меню которого хотите перейти");
                      int nomer = Convert.ToInt32(Console.ReadLine());
                      for (int i = 0; i < scheta.Count; i++)
                      {
                          if (nomer == i + 1)
                          {
                              otvet1 = "да";
                              while (otvet1 == "да")
                              {

                                  Console.WriteLine("Меню счета " + i + ": \n 1 - открыть счет \n 2 - показать информацию о счете \n 3 - положить на счет \n 4 - снять со счета \n 5 - взять всю сумму \n 6 - перенести сумму с одного счета на другой");
                                  int otvetMenu = Convert.ToInt32(Console.ReadLine());
                                  switch (otvetMenu)
                                  {
                                      case 1:
                                      case 2:
                                      case 3:
                                      case 4:
                                      case 5:
                                          scheta[i].choose(otvetMenu);
                                          break;
                                      case 6:
                                          Console.WriteLine("Введите номер счета, на который хотите перевести сумму с этого");
                                           nomer = Convert.ToInt32(Console.ReadLine());
                                          for (int j = 0; j < scheta.Count; j++)
                                          {
                                              if (nomer == j + 1)
                                              {
                                                  scheta[i].choose(scheta[j], otvetMenu);
                                                  break;

                                              }
                                          }
                                              break;


                                  }

                                  Console.WriteLine("Хотите вернуться в меню счета №" + otvetSchet + "?");
                                  otvet1 = Console.ReadLine();
                                  if (otvet1 == "нет")
                                  {
                                      break;
                                      // Console.WriteLine(""); 
                                  }


                              }

                          }
                          else
                          {
                              continue;
                          }




                      }

                  }



              }

              */










               // Console.ReadLine();


            }
        }
    }
}
