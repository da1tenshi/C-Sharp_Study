using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    public abstract class PizzaStore

    {

        public abstract Pizza createPizza(string type);

    }

    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizzaType = null;
            if (type.Equals("1"))
            {
                pizzaType = new NYstyleCheesePizza();
            }
            else if (type.Equals("2"))
            {
                pizzaType = new NYstylePeperoniPizza();
            }
            else if (type.Equals("3"))
            {
                pizzaType = new NYstyleClamPizza();
            }
            else if (type.Equals("4"))
            {
                pizzaType = new NYstyleVegglePizza();
            }
            return pizzaType;
        }


    }
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizzaType = null;
            if (type.Equals("5"))
            {
                pizzaType = new ChicagostyleCheesePizza();
            }
            else if (type.Equals("6"))
            {
                pizzaType = new ChicagostylePeperoniPizza();
            }
            else if (type.Equals("7"))
            {
                pizzaType = new ChicagostyleClamPizza();
            }
            else if (type.Equals("8"))
            {
                pizzaType = new ChicagostyleVegglePizza();
            }
            return pizzaType;
        }
    }
    public abstract class Pizza
    {
        protected string name;
        protected string testo;
        protected string souce;
        protected string secretIngredient;

        public virtual void preapare()
        {
            Console.WriteLine("Приготовленная пицца : ");
            Console.WriteLine("{0}, тесто: {1}, Соус: {2}, Секретный ингридиент: {3} ", name, testo, souce, secretIngredient);
        }
        public abstract new string GetType();
        class NYstyleCheesePizza : Pizza
        {
            public override void preapare()
            {
                name = "NYstyleCheesePizza";
                testo = "Нью-Йоркское";
                souce = "Сырный";
                secretIngredient = "Экстра сыр";
                base.preapare();
            }
            public override string GetType() { return name; }

        }
        class NYstylePeperoniPizza : Pizza
        {
            public override void preapare()
            {
                name = "NYstylePeperoniPizza";
                testo = "Нью-Йоркское";
                souce = "Кислый";
                secretIngredient = "Нарезная колбаска пеперони";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class NYstyleClamPizza : Pizza
        {
            public override void preapare()
            {
                name = "NYstyleClamPizza";
                testo = "Нью-Йоркское";
                souce = "1000 островов";
                secretIngredient = "Молюски";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class NYstyleVegglePizza : Pizza
        {
            public override void preapare()
            {
                name = "NYstyleVegglePizza";
                testo = "Нью-Йоркское";
                souce = "Острый";
                secretIngredient = "Веггли";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class ChicagostyleCheesePizza : Pizza
        {
            public override void preapare()
            {
                name = "Сырная Chi";
                testo = "Чикагское";
                souce = "Сырный";
                secretIngredient = "Экстра сыр";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class ChicagostylePeperoniPizza : Pizza
        {
            public override void preapare()
            {
                name = "Пеперони Chi";
                testo = "Чикагское";
                souce = "Кислый";
                secretIngredient = "Нарезная колбаска пеперони";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class ChicagostyleClamPizza : Pizza
        {
            public override void preapare()
            {
                name = "Молюски Chi";
                testo = "Чикагское";
                souce = "1000 островов";
                secretIngredient = "Молюски";
                base.preapare();
            }
            public override string GetType() { return name; }
        }
        class ChicagostyleVegglePizza : Pizza
        {
            public override void preapare()
            {
                name = "Veggle NY";
                testo = "Чикагское";
                souce = "Острый";
                secretIngredient = "Веггли";
                base.preapare();
            }
            public override string GetType() { return (name); }
        }

        class Program
        {
            static void Main(string[] args)
            {
                PizzaStore ps1 = new NYPizzaStore();
                Pizza pizza1 = ps1.createPizza("1");
                pizza1.preapare();
                pizza1.GetType();
                PizzaStore ps2 = new NYPizzaStore();
                Pizza pizza2 = ps2.createPizza("2");
                pizza2.preapare();
                pizza2.GetType();
                PizzaStore ps3 = new NYPizzaStore();
                Pizza pizza3 = ps3.createPizza("3");
                pizza3.preapare();
                pizza3.GetType();
                PizzaStore ps4 = new NYPizzaStore();
                Pizza pizza4 = ps4.createPizza("4");
                pizza4.preapare();
                pizza4.GetType();

                PizzaStore ps5 = new ChicagoPizzaStore();
                Pizza pizza5 = ps5.createPizza("5");
                pizza5.preapare();
                pizza5.GetType();
                PizzaStore ps6 = new ChicagoPizzaStore();
                Pizza pizza6 = ps5.createPizza("6");
                pizza6.preapare();
                pizza6.GetType();
                PizzaStore ps7 = new ChicagoPizzaStore();
                Pizza pizza7 = ps5.createPizza("7");
                pizza7.preapare();
                pizza7.GetType();
                PizzaStore ps8 = new ChicagoPizzaStore();
                Pizza pizza8 = ps5.createPizza("8");
                pizza8.preapare();
                pizza8.GetType();

                Console.ReadKey();

            }
        }
    }
}
