/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 августа 2026 08:22:56
 * Version: 1.0.358
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
