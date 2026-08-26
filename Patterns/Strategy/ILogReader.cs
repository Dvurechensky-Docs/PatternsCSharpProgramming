/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 августа 2026 06:51:52
 * Version: 1.0.377
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
