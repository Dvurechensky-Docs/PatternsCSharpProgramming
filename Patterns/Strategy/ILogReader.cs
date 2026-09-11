/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 сентября 2026 06:51:42
 * Version: 1.0.393
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
