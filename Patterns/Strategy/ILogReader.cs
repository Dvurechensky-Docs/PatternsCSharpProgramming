/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 июня 2026 06:51:39
 * Version: 1.0.310
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
