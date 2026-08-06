/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 августа 2026 06:52:12
 * Version: 1.0.357
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
