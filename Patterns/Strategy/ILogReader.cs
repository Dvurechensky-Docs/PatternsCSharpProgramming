/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 октября 2025 06:51:53
 * Version: 1.0.48
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
