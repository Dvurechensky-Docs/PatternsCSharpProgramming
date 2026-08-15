/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 августа 2026 06:51:52
 * Version: 1.0.366
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
