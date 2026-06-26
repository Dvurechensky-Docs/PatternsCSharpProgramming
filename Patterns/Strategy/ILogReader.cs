/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 июня 2026 06:51:41
 * Version: 1.0.315
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
