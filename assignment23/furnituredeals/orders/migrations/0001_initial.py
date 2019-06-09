# Generated by Django 2.2.2 on 2019-06-09 13:30

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
        ('furnitures', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Order',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('status', models.CharField(max_length=50)),
                ('date', models.DateTimeField(auto_now_add=True)),
                ('bonus', models.CharField(max_length=100)),
                ('client', models.ForeignKey(default=None, on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL)),
                ('furniture', models.ForeignKey(default=None, on_delete=django.db.models.deletion.CASCADE, to='furnitures.Furniture')),
            ],
        ),
        migrations.CreateModel(
            name='Decorator',
            fields=[
                ('order_ptr', models.OneToOneField(auto_created=True, on_delete=django.db.models.deletion.CASCADE, parent_link=True, primary_key=True, serialize=False, to='orders.Order')),
            ],
            bases=('orders.order',),
        ),
        migrations.CreateModel(
            name='HamacDecorator',
            fields=[
                ('decorator_ptr', models.OneToOneField(auto_created=True, on_delete=django.db.models.deletion.CASCADE, parent_link=True, primary_key=True, serialize=False, to='orders.Decorator')),
            ],
            bases=('orders.decorator',),
        ),
        migrations.CreateModel(
            name='ScaunDecorator',
            fields=[
                ('decorator_ptr', models.OneToOneField(auto_created=True, on_delete=django.db.models.deletion.CASCADE, parent_link=True, primary_key=True, serialize=False, to='orders.Decorator')),
            ],
            bases=('orders.decorator',),
        ),
    ]