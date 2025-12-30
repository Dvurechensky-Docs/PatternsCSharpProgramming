/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 декабря 2025 10:15:52
 * Version: 1.0.135
 */

/*  Декоратор
    Динамически предоставляет объекту
    дополнительные возможности. Представляет
    собой гибкую альтернативу наследованию
    для расширения функциональности.
 */
class Program
{
    static void Main()
    {
        #region Пример №1 - базовое
        Pizza r = new RussianPizza();
        Console.WriteLine(r.GetCost()); 
        Pizza i = new TomatoPizza(r);
        Console.WriteLine(i.GetCost());
        Console.ReadKey();
        #endregion
    }
}

abstract class Pizza
{
    public string Name { get; set; }
    public Pizza(string name)
    {
        Name = name;
    }
    public abstract int GetCost();
}

class RussianPizza : Pizza
{
    public RussianPizza() : base("Russian Pizza")
    {
    }

    public override int GetCost()
    {
        return 1000;
    }
}

abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;
    protected PizzaDecorator(string name, Pizza pizza) : base(name)
    {
        this.pizza = pizza;
    }
}

class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza pizza) : base(pizza.Name + ", tomato", pizza)
    {
    }

    public override int GetCost()
    {
        return pizza.GetCost() + 100;
    }
}
