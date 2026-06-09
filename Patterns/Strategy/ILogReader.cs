/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 июня 2026 16:52:43
 * Version: 1.0.298
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
