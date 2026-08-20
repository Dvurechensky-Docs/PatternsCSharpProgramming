/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 августа 2026 09:35:54
 * Version: 1.0.371
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
