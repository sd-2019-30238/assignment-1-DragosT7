from django.db import models
from django.contrib.auth.models import User
from furnitures import models as furnitureModels
import six
from abc import ABCMeta

# Create your models here.

class Order(models.Model):
    client = models.ForeignKey(User, default=None, on_delete=models.CASCADE)
    furniture = models.ForeignKey(furnitureModels.Furniture, default=None, on_delete=models.CASCADE)
    status = models.CharField(max_length=50)
    date = models.DateTimeField(auto_now_add=True)
    bonus = models.CharField(max_length=100)

    def __str__(self):
        return str(self.id)

    def getBonusProduct(self):
        return "Standard"


class Decorator(Order):
    def __init__(self, order, bonusType):
        self.order = order
        self.order.bonus = bonusType
    def getBonusProduct(self):
        return self.order.getBonusProduct()

class ScaunDecorator(Decorator):
    def __init__(self, order):
        Decorator.__init__(self, order, "Scaun Ingolf")
    def getBonusProduct(self):
        return self.getBonusProduct() + ", plus scaun."

class HamacDecorator(Decorator):
    def __init__(self, order):
        Decorator.__init__(self, order, "Hamac Fredon")
    def getBonusProduct(self):
        return self.getBonusProduct() + ", plus hamac"