/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 августа 2026 06:51:48
 * Version: 1.0.363
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
