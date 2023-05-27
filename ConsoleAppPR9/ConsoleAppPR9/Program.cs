using System;

namespace ConsoleAppPR9
{
    interface IInstrument
    {
        public abstract void Instr();
    }
    interface IIspolInstr
    {
        public abstract void Ispol();

    }
    class Stremanka: IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Стремянка используется чтобы ");
        }
    }
    class Rulet : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Рулетка используется чтобы ");
        }
    }
    class Yrov : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Уровень используется чтобы ");
        }
    }
    class Shpatel : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Шпатель используется чтобы ");
        }
    }
    class Lobzik : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Лобзик используется чтобы ");
        }
    }
    class Valik : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Валик используется чтобы ");
        }
    }
    class Molotok : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Молоток используется чтобы ");
        }
    }
    class Otvertka : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Отвертка используется чтобы ");
        }
    }
    class Nogg : IInstrument
    {
        public void Instr()
        {
            Console.WriteLine("Нож используется чтобы ");
        }
    }

    class Lezt : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Лезть ");
        }
    }
    class Izmer : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Измерять");
        }
    }
    class Veravnit : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Выравнивать");
        }
    }
    class NanosKle : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Наносить клей");
        }
    }
    class Rezac : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Резать");
        }
    }
    class Krut : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Крутить");
        }
    }
    class Zabiva : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Забивать");
        }
    }
    class Kras : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Красить");
        }
    }
    class Piliti : IIspolInstr
    {
        public void Ispol()
        {
            Console.WriteLine("Пилить");
        }
    }

    abstract class Yslug
    {
        public abstract IInstrument Instrument();
        public abstract IIspolInstr IspolInstr();


    }
    class Vurav : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Stremanka();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Lezt();
        }
    }
    class Vurav1 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Rulet();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }

    }
    class Vurav2 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Yrov();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
        

    }
    class Vurav3 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Shpatel();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Veravnit();
        }

    }
    class YstMolding1 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Stremanka();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Lezt();
        }
    }
    class YstMolding2 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Rulet();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
    }
    class YstMolding3 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Yrov();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
    }
    class YstMolding4 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Shpatel();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Veravnit();
        }
    }
    class YstMolding5 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Nogg();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Rezac();
        }
    }
    class PoklOboev1 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Stremanka();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Lezt();
        }
    }
    class PoklOboev2 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Rulet();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
    }
    class PoklOboev3 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Yrov();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
    }
    class PoklOboev4 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Shpatel();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Veravnit();
        }
    }
    class PoklOboev5 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Valik();
        }
        public override IIspolInstr IspolInstr()
        {
            return new NanosKle();
        }
    }
    class PoklOboev6 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Nogg();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Rezac();
        }
    }

    class YkladPola1 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Rulet();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Izmer();
        }
    }
    class YkladPola2 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Otvertka();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Krut();
        }
    }
    class YkladPola3 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Molotok();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Zabiva();
        }
    }
    class YkladPola4 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Shpatel();
        }
        public override IIspolInstr IspolInstr()
        {
            return new NanosKle();
        }
    }
    class YkladPola5 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Valik();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Kras();
        }
    }
    class YkladPola6 : Yslug
    {
        public override IInstrument Instrument()
        {
            return new Lobzik();
        }
        public override IIspolInstr IspolInstr()
        {
            return new Rezac();
        }
    }
    class Polizovatel
    {
        private IInstrument instrument;
        private IIspolInstr ispolInstr;
        public Polizovatel(Yslug yslug)
        {
            instrument = yslug.Instrument();
            ispolInstr = yslug.IspolInstr();
        }
        public void Polz()
        {
            instrument.Instr();

        }
        public void Polz2()
        {
            ispolInstr.Ispol();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            int p=0;
            Console.WriteLine("Выберите услуги - 1 Выравнивание стен;2 Установка молдингов;3 Поклейка обоев; 4 Укладка пола");
            
            for(int i=0;p<=4;i++)
            {
                
                p = Convert.ToInt32(Console.ReadLine());
                if(p==1)
                {
                    Polizovatel polizovatel = new Polizovatel(new Vurav());
                    polizovatel.Polz();
                    polizovatel.Polz2();

                    Polizovatel polizovatel2 = new Polizovatel(new Vurav1());
                    polizovatel2.Polz();
                    polizovatel2.Polz2();

                    Polizovatel polizovatel3 = new Polizovatel(new Vurav2());
                    polizovatel3.Polz();
                    polizovatel3.Polz2();

                    Polizovatel polizovatel4 = new Polizovatel(new Vurav3());
                    polizovatel4.Polz();
                    polizovatel4.Polz2();
                }
                if(p==2)
                {
                    Polizovatel polizovatel1 = new Polizovatel(new YstMolding1());
                    polizovatel1.Polz();
                    polizovatel1.Polz2();

                    Polizovatel polizovatel2 = new Polizovatel(new YstMolding2());
                    polizovatel2.Polz();
                    polizovatel2.Polz2();

                    Polizovatel polizovatel3 = new Polizovatel(new YstMolding3());
                    polizovatel3.Polz();
                    polizovatel3.Polz2();

                    Polizovatel polizovatel4 = new Polizovatel(new YstMolding4());
                    polizovatel4.Polz();
                    polizovatel4.Polz2();

                    Polizovatel polizovatel5 = new Polizovatel(new YstMolding5());
                    polizovatel5.Polz();
                    polizovatel5.Polz2();
                }
                if(p==3)
                {
                    Polizovatel polizovatel1 = new Polizovatel(new PoklOboev1());
                    polizovatel1.Polz();
                    polizovatel1.Polz2();

                    Polizovatel polizovatel2 = new Polizovatel(new PoklOboev2());
                    polizovatel2.Polz();
                    polizovatel2.Polz2();

                    Polizovatel polizovatel3 = new Polizovatel(new PoklOboev3());
                    polizovatel3.Polz();
                    polizovatel3.Polz2();

                    Polizovatel polizovatel4 = new Polizovatel(new PoklOboev4());
                    polizovatel4.Polz();
                    polizovatel4.Polz2();

                    Polizovatel polizovatel5 = new Polizovatel(new PoklOboev5());
                    polizovatel5.Polz();
                    polizovatel5.Polz2();

                    Polizovatel polizovatel6 = new Polizovatel(new PoklOboev6());
                    polizovatel6.Polz();
                    polizovatel6.Polz2();
                }
                if (p == 4)
                {
                    Polizovatel polizovatel1 = new Polizovatel(new YkladPola1());
                    polizovatel1.Polz();
                    polizovatel1.Polz2();

                    Polizovatel polizovatel2 = new Polizovatel(new YkladPola2());
                    polizovatel2.Polz();
                    polizovatel2.Polz2();

                    Polizovatel polizovatel3 = new Polizovatel(new YkladPola3());
                    polizovatel3.Polz();
                    polizovatel3.Polz2();

                    Polizovatel polizovatel4 = new Polizovatel(new YkladPola4());
                    polizovatel4.Polz();
                    polizovatel4.Polz2();

                    Polizovatel polizovatel5 = new Polizovatel(new YkladPola5());
                    polizovatel5.Polz();
                    polizovatel5.Polz2();

                    Polizovatel polizovatel6 = new Polizovatel(new YkladPola6());
                    polizovatel6.Polz();
                    polizovatel6.Polz2();
                }

            }

        }
    }
}
