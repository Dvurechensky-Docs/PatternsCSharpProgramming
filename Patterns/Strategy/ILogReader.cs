/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 октября 2025 06:51:50
 * Version: 1.0.62
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
