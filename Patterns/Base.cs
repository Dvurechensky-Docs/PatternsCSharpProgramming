/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2026 07:43:32
 * Version: 1.0.426
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
