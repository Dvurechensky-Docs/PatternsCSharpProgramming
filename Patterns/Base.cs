/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:51:46
 * Version: 1.0.132
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
