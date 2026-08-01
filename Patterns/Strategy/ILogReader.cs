/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 августа 2026 06:52:00
 * Version: 1.0.352
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
