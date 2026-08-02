/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 августа 2026 06:51:50
 * Version: 1.0.353
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
