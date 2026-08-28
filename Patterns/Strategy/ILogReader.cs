/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2026 06:51:43
 * Version: 1.0.379
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
