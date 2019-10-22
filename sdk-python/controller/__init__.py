import requests
from static import BASE_URL, HELLO_WORLD, METHOD_GET
from static.HeaderUtils import getHeaders


def helloWorld():

    url = BASE_URL + HELLO_WORLD

    headers = getHeaders(METHOD_GET, HELLO_WORLD)

    response = requests.get(url, headers=headers)

    """ For Post Method here is an example
    -> data ='{"Key1":"Value1", "Key2":"Value2"}'
    -> response = requests.get(url, headers=headers, data=data) """

    print("code:" + str(response.status_code))
    print("---------------------")
    print("headers:" + str(response.headers))
    print("---------------------")
    print("content:" + str(response.content))
    print("---------------------")

    return response.content