/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:39:46
 * Version: 1.0.14
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
