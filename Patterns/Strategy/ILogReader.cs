/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 августа 2026 06:51:48
 * Version: 1.0.375
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
