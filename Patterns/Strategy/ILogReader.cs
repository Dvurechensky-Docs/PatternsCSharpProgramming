/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 июля 2026 07:00:51
 * Version: 1.0.329
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
