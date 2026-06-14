/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 июня 2026 16:34:41
 * Version: 1.0.303
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
