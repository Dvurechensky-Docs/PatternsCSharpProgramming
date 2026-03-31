/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:53:05
 * Version: 1.0.226
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
