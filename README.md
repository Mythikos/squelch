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
9. [Improvement/Localization] Update the app to only use the string language documents to enable multi-language support for the app.

## Working
Modify code and layout files to use strings.xml instead of hardcoded values. Remaining:

Resources/layouts/
* ALL LAYOUT FILES

Resources/Menu/
* Navigation

## Changelog:
n/a
