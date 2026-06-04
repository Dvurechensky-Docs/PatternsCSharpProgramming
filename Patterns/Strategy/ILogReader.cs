/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 июня 2026 06:51:41
 * Version: 1.0.293
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
