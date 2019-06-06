from django.shortcuts import render
from django.http import HttpResponse
from furnitures.models import Furniture

class RequestAllFurnitures:
    def __init__(self, request, filterType="name"):
        self.filterType = filterType
        self.request = request

    def getFilterType(self):
        return self.filterType

    def getRequest(self):
        return self.request

class RequestAllFurnituresHandle:
    def handle(self, requestObject):
        furnitures = Furniture.objects.all().order_by(requestObject.getFilterType())
        return render(requestObject.getRequest(), 'furnitures/furnitures_list.html', {'furnitures': furnitures})

class RequestSpecificFurniture:
    def __init__(self, request, slug):
        self.request = request
        self.slug = slug

    def getRequest(self):
        return self.request

    def getSlug(self):
        return self.slug

class RequestSpecificFurnitureHandle:
    def handle(self, requestObject):
        furniture = Furniture.objects.get(slug=requestObject.getSlug())
        return render(requestObject.getRequest(), 'furnitures/furnitures_detail.html', {'furniture': furniture})


handlerDictionary = {"RequestAllFurnitures": RequestAllFurnituresHandle,
                     "RequestSpecificFurniture": RequestSpecificFurnitureHandle,
                    }
class Mediator:
    def mediate(self, requestObject):
        return handlerDictionary[requestObject.__class__.__name__]().handle(requestObject)