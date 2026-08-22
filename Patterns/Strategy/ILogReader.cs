/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 августа 2026 14:39:24
 * Version: 1.0.373
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
