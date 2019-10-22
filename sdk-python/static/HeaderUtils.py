import base64
import hashlib
import hmac

from static.Utility import getCurrentUTCTime, isValidString
from static import USER_TOKEN, PUBLIC_KEY, PRIVATE_KEY, __SERVER_IP__


def getHeaders(methodType, methodName):
    """ headersUtils:
        methodType -> 'GET' or 'POST'
        methodName -> 'Demo/HelloWorld' """

    # Step 1: Add Current Date Time in UTC format eg: 'Tuesday, Nov 28, 2017 11:51:37 AM'
    utcDate = getCurrentUTCTime()

    headers = {"Timestamp": utcDate}

    # Step 2: Add Your System Ip Address
    headers['IpAddress']= __SERVER_IP__

    # Step 3: Add User token as an User Auth Key
    headers['UserToken']= USER_TOKEN

    # Step 4: Generate Authentication Key with private Key and
    message = buildAuthSignature(methodType, utcDate, __SERVER_IP__, USER_TOKEN, str.lower(methodName))

    # Step 5: Generate Authentication with public key and private key
    headers['Authentication'] = PUBLIC_KEY + ":" + computeHashKey(PRIVATE_KEY, message)

    return headers



def buildAuthSignature(methodType, utcDate, __SERVER_IP__, USER_TOKEN, absolutePath):
    """ buildAuthSignature:
            methodType   ->  'GET' or 'POST'
            date         ->  '%A, %b %d, %Y %I:%M:%S %p'  like  'Sunday, Jan 01, 2020 10:10:00 AM'
            absolutePath ->  'demo/HelloWorld'
    """

    absolutePath = "/" + absolutePath
    from urlparse import urlparse
    url=""

    if isValidString(urlparse(absolutePath).path):
        url = urlparse(absolutePath).path

    if isValidString(urlparse(absolutePath).query):
        url = url + urlparse(absolutePath).query

    sentence = [methodType, utcDate, __SERVER_IP__, USER_TOKEN, absolutePath]
    return '\n'.join(sentence)



def computeHashKey(privateKey, message):
    """ buildAuthSignature:
               privateKey   ->  Your private Key
               message      ->  buildAuthSignature generated message """

    message = bytes(message).encode('utf-8')
    secret = bytes(privateKey).encode('utf-8')
    signature = base64.b64encode(hmac.new(secret, message, digestmod=hashlib.sha256).digest())
    return signature
