/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 августа 2026 06:52:07
 * Version: 1.0.355
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
