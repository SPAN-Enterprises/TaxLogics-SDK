import datetime


def getCurrentUTCTime():
    return datetime.datetime.utcnow().strftime("%A, %b %d, %Y %I:%M:%S %p")


def isValidString(text):
    if text and text.strip():
        # myString is not None AND myString is not empty or blank
        return True
        # myString is None OR myString is empty or blank
    return False
