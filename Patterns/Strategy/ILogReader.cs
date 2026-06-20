/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 июня 2026 06:51:36
 * Version: 1.0.309
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
