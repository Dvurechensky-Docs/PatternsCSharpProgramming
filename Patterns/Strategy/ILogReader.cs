/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 августа 2026 06:51:51
 * Version: 1.0.361
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
