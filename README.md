# Squelch

## Todo / Enhancements
1. [Feature] Add recurring schedules (perhaps use crontab?).
2. [Feature] Add additional modes into the blackout process, such as VPN mode.
3. [Feature] Add pre-set app list(s) that users can define for the blackout setup process.
4. [Feature] Add quick blackout options to home fragment (quick 30 mins, full lockouts, etc).
5. [Improvement] Modify how the quick options work for date selection on the BlackoutSetupFragment. It can be confusing for the user to select "NOW" and by the time they are done setting it up, time has already passed.
6. [Feature] Add trash talk option to overlay (user configurable).
7. [Improvement] Add a job scheduler that checks to see if the EnforcerService is running, and if not, start it back up.
8. [Improvement] Add Crashlytics

## Working:
* Still need to update the statistics fragment to use localized strings.
* Need to fix weird ordering on schedule fragment as a result of localization.
* Need to fix the blackout fragment so that it doesn't rely on the text of the buttons to indicate if its done (might just ignore seeing Next/Finish wont be the same word... maybe?).

## Changelog:
* Added time format user setting.
* Added DateUtils class for formatting datetimes using Android's built in DateUtil and SimpleDateFormatter.
* Updated all text sources to use localized strings instead of hardcoded strings.
* Updated in app billing plugin to v4.
