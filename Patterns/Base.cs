/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 января 2026 13:16:45
 * Version: 1.0.149
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
