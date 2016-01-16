using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Creational.ObjectPool
{
    public abstract class ObjectPool<T>
    {
        private readonly TimeSpan _expirationTime;
        private readonly Dictionary<T, DateTime> _locked;
        private readonly Dictionary<T, DateTime> _unlocked;

        protected ObjectPool()
        {
            _expirationTime = TimeSpan.FromSeconds(30);
            _locked = new Dictionary<T, DateTime>();
            _unlocked = new Dictionary<T, DateTime>();
        }

        protected abstract T Create();

        protected abstract bool Validate(T @object);

        protected abstract void Expire(T @object);

        [MethodImpl(MethodImplOptions.Synchronized)]
        public T Acquire()
        {
            var now = DateTime.UtcNow;

            var @object = default(T);
            var unlock = new List<T>();

            foreach (var instance in _unlocked.Keys)
            {
                if (now - _unlocked[instance] > _expirationTime)
                {
                    unlock.Add(instance);
                    Expire(instance);
                }
                else
                {
                    if (Validate(instance))
                    {
                        unlock.Add(instance);
                        _locked.Add(instance, now);
                        @object = instance;
                        break;
                    }

                    unlock.Add(instance);
                    Expire(instance);
                }
            }

            foreach (var instance in unlock)
            {
                _unlocked.Remove(instance);
            }

            if (@object != null)
            {
                return @object;
            }

            @object = Create();
            _locked.Add(@object, now);
            return @object;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Release(T @object)
        {
            _locked.Remove(@object);
            _unlocked.Add(@object, DateTime.UtcNow);
        }
    }
}