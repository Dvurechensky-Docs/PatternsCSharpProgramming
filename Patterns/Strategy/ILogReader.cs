/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2026 06:51:31
 * Version: 1.0.382
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
