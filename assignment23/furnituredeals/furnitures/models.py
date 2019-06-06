from django.db import models

# Create your models here.

class Furniture(models.Model):
    name = models.CharField(max_length=100)
    description = models.TextField()
    oldPrice = models.PositiveIntegerField()
    newPrice = models.PositiveIntegerField()
    saleType = models.CharField(max_length=25)
    quantity = models.PositiveIntegerField()
    slug = models.SlugField()

    def __str__(self):
        return self.name

    def getSnippet(self):
        return self.description[:50]