/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 мая 2026 12:48:36
 * Version: 1.0.276
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
