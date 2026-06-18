/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 июня 2026 06:51:44
 * Version: 1.0.307
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
