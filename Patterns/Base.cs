/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 июня 2026 06:51:39
 * Version: 1.0.306
 */

using System;

public class Base


//абстрактный класс
abstract class AbstrTest
{
    void Move()
    {

    }

    //реализация по умолчанию
    public virtual void Resize()
    {

    }
    void Declare();
}

public class Class_Main : AbstrTest
{
    public Class_Main()
    {
        Declare();
    }
}
